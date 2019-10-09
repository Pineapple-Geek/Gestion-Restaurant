using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetRestoSQLServeur.IHM.Table.Ajouter;
using ProjetRestoSQLServeur.IHM.Table.Modifier;

namespace ProjetRestoSQLServeur.IHM.Table
{
  public partial class FormTable : Form
  {
    public FormTable()
    {
      InitializeComponent();
      Init();
    }

    private void btAcceuil_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Init()
    {
      List<Tablee> desTablee;
      desTablee = Tablee.GetTablee();
      foreach (Tablee t in desTablee)
      {
        if (t.numTablee != 0)
        {
          ListViewItem LTablee;
          LTablee = new ListViewItem(new String[] { t.numTablee.ToString(), t.nbPlaceTablee.ToString()});
          lv_Table.Items.Add(LTablee);
        }
      }
    }

    private void Bouton_Ajouter_Click(object sender, EventArgs e)
    {
      FormTableAjouter formTableAjouter = new FormTableAjouter();
      formTableAjouter.ShowDialog();
      lv_Table.Items.Clear();
      Init();
    }

    private void Bouton_Modifier_Click(object sender, EventArgs e)
    {
      try
      {
        if (lv_Table.SelectedItems[0].SubItems[0].Text != null)
        {
          new FormTableModifier(int.Parse(lv_Table.SelectedItems[0].SubItems[0].Text)).ShowDialog();
          lv_Table.Items.Clear();
          Init();
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Sélectionner une table!");
      }
    }

    private void Bouton_Supprimer_Click(object sender, EventArgs e)
    {
      try
      {
        B_Tablee.Delete(Convert.ToInt32(lv_Table.SelectedItems[0].SubItems[0].Text));
        lv_Table.Items.RemoveAt(lv_Table.SelectedItems[0].Index);
        lv_Table.Refresh();

        //revenir Menu
        // A compléter
      }
      catch (Exception)
      {
        MessageBox.Show("Sélectionner une table!");
      }
    }
  }
}
