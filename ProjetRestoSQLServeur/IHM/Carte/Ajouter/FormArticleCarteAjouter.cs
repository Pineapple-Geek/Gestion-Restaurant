using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetRestoSQLServeur
{
    public partial class FomArticleCarteAjouter : Form
    {
        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        public FomArticleCarteAjouter()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Fonction Click du bouton Ajouter
        /// </summary>
        public void B_AjServFin_Click(object sender, EventArgs e)
        {
          int prix = 0;
          bool isNumberPrix = int.TryParse(TB_Prix_Plat.Text, out prix); // Vérifier que le prix saisie et bien écrit avec des chiffre

          if (isNumberPrix == true) // Si le prix est bien un nombre
          {
            B_Article.Add(Convert.ToString(TB_Nom_Plat.Text), Convert.ToInt32(TB_Prix_Plat.Text), Convert.ToString(TB_Photo_Plat.Text), Convert.ToInt32(CB_Type_Plats.SelectedValue)); // Appel de la fonction Add de B_Article
            this.Close(); // Fermeture du formulaire
          }
          else
          {
            MessageBox.Show("Veuillez saisir des chiffres pour le prix!"); // Affiche un message si erreur
          }
        }

        /// <summary>
        ///  Fonction Load du Formulaire
        /// </summary>
        public void FPAjouter_Load(object sender, EventArgs e)
        {
            List<CategorieArticle> uneCatArticle; // Creation d'une liste de categorie
            uneCatArticle = CategorieArticle.GetCategoriePlats(); //Récupération de toute les Categorie de la BDD

            CB_Type_Plats.DataSource = uneCatArticle; // Stockages des categorie dans la ComboBox
            CB_Type_Plats.ValueMember = "idCatArticle";
            CB_Type_Plats.DisplayMember = "libelleCatArticle";

            this.ControlBox = false; //Désactivation de ControlBox

        }

        /// <summary>
        ///  Fonction Click du bouton Retour
        /// </summary>
        private void retour_Click(object sender, EventArgs e)
        {
          this.Close(); // Fermeture du formulaire
        }
     }
}
