using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetRestoSQLServeur.IHM.Commandes.Nouveau
{
  public partial class FormCommandesNouveau : Form
  {
    public FormCommandesNouveau()
    {
      InitializeComponent();
      Init();
    }

    private void Init()
    {
      List<Tablee> uneTablee; // Creation d'une liste de table
      uneTablee = Tablee.GetTablee(); //Récupération de toute les table de la BDD

      List<Serveur> uneServeur; // Creation d'une liste de table
      uneServeur = Serveur.GetServeur();  //Récupération de toute les table de la BDD

      CB_NumTable.DataSource = uneTablee; // Stockages des table dans la ComboBox
      CB_NumTable.ValueMember = "numTablee";
      CB_NumTable.DisplayMember = "numTablee";

      CB_IdServeur.DataSource = uneServeur; // Stockages des table dans la ComboBox
      CB_IdServeur.ValueMember = "idServeur";
      CB_IdServeur.DisplayMember = "nomServeur";

      this.ControlBox = false; //Désactivation de ControlBox

    }

    private void retour_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void B_Ajouter_Click(object sender, EventArgs e)
    {
      B_Commande.Add(Convert.ToInt32(CB_NumTable.Text), Convert.ToInt32(CB_IdServeur.SelectedValue));
      this.Close();
    }
  }
}
