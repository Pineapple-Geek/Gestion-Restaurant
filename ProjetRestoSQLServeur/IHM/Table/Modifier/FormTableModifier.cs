using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetRestoSQLServeur.IHM.Table.Modifier
{
  public partial class FormTableModifier : Form
  {
    public FormTableModifier(int numTable)
    {
      InitializeComponent();
      Init(numTable);
    }

    public void Init(int numTable)
    {
      Tablee unTable = Tablee.GetInstance(numTable);
      TB_Num_Table.Text = unTable.numTablee.ToString();
      TB_Nbr_Place.Text = unTable.nbPlaceTablee.ToString();
    }

    private void B_Retour_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void B_ModifierTable_Click(object sender, EventArgs e)
    {
      int nbPlace = 0;
      int nbTable = 0;
      bool isNumberPlace = int.TryParse(TB_Nbr_Place.Text, out nbPlace);
      bool isNumberTable = int.TryParse(TB_Num_Table.Text, out nbTable);

      if (isNumberPlace == true && isNumberTable == true)
      {
        B_Tablee.Update(Convert.ToInt32(TB_Num_Table.Text), Convert.ToInt32(TB_Nbr_Place.Text));
        this.Close();
      }
      else
      {
        MessageBox.Show("Veuillez saisir des chiffres!");
      }
    }
  }
}
