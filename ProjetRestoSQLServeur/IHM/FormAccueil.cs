using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetRestoSQLServeur.IHM.Personnel;
using ProjetRestoSQLServeur.IHM.Table;
using ProjetRestoSQLServeur.IHM.Commandes;

namespace ProjetRestoSQLServeur
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btCarte_Click(object sender, EventArgs e)
    {
      FormArticleCarte formArticleCarte = new FormArticleCarte();
      formArticleCarte.ShowDialog();
    }

    private void btPersonnel_Click(object sender, EventArgs e)
    {
      FormPersonnel formPersonnel = new FormPersonnel();
      formPersonnel.ShowDialog();
    }

    private void btTable_Click(object sender, EventArgs e)
    {
      FormTable formTable = new FormTable();
      formTable.ShowDialog();
    }

    private void btCommande_Click(object sender, EventArgs e)
    {
      FormCommandes formCommandes = new FormCommandes();
      formCommandes.ShowDialog();
    }
  }
}
