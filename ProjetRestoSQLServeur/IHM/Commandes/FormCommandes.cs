using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetRestoSQLServeur.IHM.Commandes.Ajouter;
using ProjetRestoSQLServeur.IHM.Commandes.Nouveau;

namespace ProjetRestoSQLServeur.IHM.Commandes
{
  public partial class FormCommandes : Form
  {
    public FormCommandes()
    {
      InitializeComponent();
      Init();
    }

    private void Init()
    {
      List<Commande> desCommande; // Création d'une liste d'article
      desCommande = Commande.GetCommande(); // Récupération de la liste de tout les article lister dans la BDD
      foreach (Commande c in desCommande)
      {
        if (c.numCommande != 0)
        {
          ListViewItem LCommande; // Création d'une ListViewItem
          LCommande = new ListViewItem(new String[] { c.numCommande.ToString(), c.dateHeureCommance.ToString(), c.numTablee.ToString(), c.idServeur.ToString(), c.termine.ToString() }); // Stockage du contenue de a et c dans la ListViewItem
          lv_Commande.Items.Add(LCommande); //Ajouter le contenue de ListViewItem dans notre ListView 
        }
      }
    }

    private void btAcceuil_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Bouton_NewCommande_Click(object sender, EventArgs e)
    {
      FormCommandesNouveau formCommandesNouveau = new FormCommandesNouveau();
      formCommandesNouveau.ShowDialog();
    }
  }
}
