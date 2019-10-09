using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetRestoSQLServeur.IHM.Personnel.Ajouter
{
  public partial class FormPersonnelAjouter : Form
  {
    public FormPersonnelAjouter()
    {
      InitializeComponent();
    }

    private void B_Retour_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void B_AjouterServeur_Click(object sender, EventArgs e)
    {
      bool etatServeur = Convert.ToBoolean(CB_Etat_Serveur.SelectedIndex);
      B_Serveur.Add(Convert.ToString(TB_Nom_Serveur.Text), Convert.ToString(TB_Prenom_Serveur.Text), etatServeur);
      this.Close();
    }

    private void FormPersonnelAjouter_Load(object sender, EventArgs e)
    {
      CB_Etat_Serveur.Items.Add("NonActif");
      CB_Etat_Serveur.Items.Add("Actif");
    }
  }
}
