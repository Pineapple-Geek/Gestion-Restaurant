using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetRestoSQLServeur.IHM.Table.Ajouter
{
  public partial class FormTableAjouter : Form
  {
    public FormTableAjouter()
    {
      InitializeComponent();
    }

    private void B_Retour_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void B_AjouterTable_Click(object sender, EventArgs e)
    {
      int nbPlace = 0;
      bool isNumber = int.TryParse(TB_Nombre_Place.Text, out nbPlace);
      if (isNumber == true)
      {
        B_Tablee.Add(Convert.ToInt32(TB_Nombre_Place.Text));
        this.Close();
      }
      else
      {
        MessageBox.Show("Veuillez saisir des chiffres!");
      }
    }
  }
}
