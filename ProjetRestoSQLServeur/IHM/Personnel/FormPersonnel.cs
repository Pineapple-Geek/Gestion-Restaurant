using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetRestoSQLServeur.IHM.Personnel.Ajouter;
using ProjetRestoSQLServeur.IHM.Personnel.Modifier;

namespace ProjetRestoSQLServeur.IHM.Personnel
{
  public partial class FormPersonnel : Form
  {
    public FormPersonnel()
    {
      InitializeComponent();
      Init();
    }

    private void Init()
    {
      string etatServeur;
      List<Serveur> desServeur;
      desServeur = Serveur.GetServeur();
      foreach (Serveur s in desServeur)
      {
            if (s.idServeur != 0)
            {
              ListViewItem LServeur;

              if (s.actif == true)
              {
                etatServeur = "Actif";
              }
              else
              {
                etatServeur = "NonActif";
              }

              LServeur = new ListViewItem(new String[] { s.idServeur.ToString(), s.nomServeur, s.prenomServeur, etatServeur });
              lv_Serveur.Items.Add(LServeur);
            }
      }
    }

    private void btAcceuil_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Bouton_Ajouter_Click(object sender, EventArgs e)
    {
      FormPersonnelAjouter formPersonnelAjouter = new FormPersonnelAjouter();
      formPersonnelAjouter.ShowDialog();
      lv_Serveur.Items.Clear();
      Init();
    }

    private void Bouton_Modifier_Click(object sender, EventArgs e)
    {
      try
      {
        if (lv_Serveur.SelectedItems[0].SubItems[0].Text != null)
        {
          new FormPersonnelModifier(int.Parse(lv_Serveur.SelectedItems[0].SubItems[0].Text)).ShowDialog();
          lv_Serveur.Items.Clear();
          Init();
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Sélectionner un serveur!");
      }
    }

    private void Bouton_Supprimer_Click(object sender, EventArgs e)
    {
      try
      {
        B_Serveur.Delete(Convert.ToInt32(lv_Serveur.SelectedItems[0].SubItems[0].Text));
        lv_Serveur.Items.RemoveAt(lv_Serveur.SelectedItems[0].Index);
        lv_Serveur.Refresh();

        //revenir Menu
        // A compléter
      }
      catch (Exception)
      {
        MessageBox.Show("Sélectionner un serveur!");
      }
    }
  }
}
