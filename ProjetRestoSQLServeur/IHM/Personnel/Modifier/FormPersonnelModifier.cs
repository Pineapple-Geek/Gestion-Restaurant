using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetRestoSQLServeur.IHM.Personnel.Modifier
{
  public partial class FormPersonnelModifier : Form
  {
    public int index;
    public FormPersonnelModifier(int unId)
    {
      InitializeComponent();
      index = unId;
      Init(index);
    }

    public void Init(int unId)
    {
      Serveur unServeur = Serveur.GetInstance(unId);
      TB_Nom_Serveur.Text = unServeur.nomServeur.ToString();
      TB_Prenom_Serveur.Text = unServeur.prenomServeur.ToString();
      CB_Etat_Serveur.Items.Add("NonActif");
      CB_Etat_Serveur.Items.Add("Actif");
    }

    private void B_Retour_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void B_ModifierServeur_Click(object sender, EventArgs e)
    {
      B_Serveur.Update(index, TB_Nom_Serveur.Text, TB_Prenom_Serveur.Text, Convert.ToBoolean(CB_Etat_Serveur.SelectedIndex));
      this.Close();
    }
  }
}
