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
    public partial class FormArticleCarte : Form
    {
        /// <summary>
        /// Constructeur du formulaire FormArticleCarte
        /// </summary>
        public FormArticleCarte()
            {
                InitializeComponent();
                Init();
            }

        /// <summary>
        /// Fonction d'initialisation du ListView
        /// </summary>
        private void Init()
        {

            List<CategorieArticle> desCatArtciles; // Création d'une liste de categorie d'article
            desCatArtciles = CategorieArticle.GetCategorieArticle(); // Récuperation des catégorie lister dans la BDD

            List<Article> desArticles; // Création d'une liste d'article
            desArticles = Article.GetArticle(); // Récupération de la liste de tout les article lister dans la BDD
            foreach (Article a in desArticles) 
                  {
                foreach (CategorieArticle c in desCatArtciles)
                {
                    if (a.idCatArticle == c.idCatArticle)
                    {
                        if (a.idCatArticle != 0)
                        {
                            ListViewItem LArticle; // Création d'une ListViewItem
                            LArticle = new ListViewItem(new String[] { a.idArticle.ToString(), a.designationArticle, a.prixArticle.ToString(), a.photoArticle, c.libelleCatArticle }); // Stockage du contenue de a et c dans la ListViewItem
                            lv_Article.Items.Add(LArticle); //Ajouter le contenue de ListViewItem dans notre ListView 
                        }
                    }   
                }   
            }
        }

        /// <summary>
        /// Fonction Click du bouton Ajouter
        /// </summary>
        private void Bouton_Ajouter_Click(object sender, EventArgs e)
        {
            FomArticleCarteAjouter fpa = new FomArticleCarteAjouter(); //Instantiation du formulaire FormArticleCarteAjouter
            fpa.ShowDialog(); // Affichage du formulaire
            lv_Article.Items.Clear(); // Effacement complet de la ListView
            Init(); // Chargement de la fonction Init
        }

        /// <summary>
        /// Fonction Click du bouton Supprimer
        /// </summary>
        private void Bouton_Supprimer_Click(object sender, EventArgs e)
            {
            try
            { 
                B_Article.Delete(Convert.ToInt32(lv_Article.SelectedItems[0].SubItems[0].Text)); // Apple de la fonction Delete de B_Article 
                lv_Article.Items.RemoveAt(lv_Article.SelectedItems[0].Index); // Suppresion de l'item selectionné dans la ListView
                lv_Article.Refresh(); // refraichisement de la ListView
                
				//revenir Menu
                // A compléter
            }
            catch (Exception)
            {
                MessageBox.Show("Sélectionner un article!"); // Affichage d'un message si erreur
            }

}
        /// <summary>
        /// Fonction Click du bouton Modifier
        /// </summary>
        private void Bouton_Modifier_Click(object sender, EventArgs e)
            {
            try
            {
              if (lv_Article.SelectedItems[0].SubItems[0].Text != null) // Verifier si l'Item selectionner et différent de null
              {
                new FormArticleCarteModif(int.Parse(lv_Article.SelectedItems[0].SubItems[0].Text)).ShowDialog(); // Affichage du formulaire FormArticleCarteModif avec l'index de l'item selectionné
                lv_Article.Items.Clear(); // Effacement complet de la ListView
                Init(); // Chargement de la fonction Init
              }
            }
            catch (Exception)
            {
                MessageBox.Show("Sélectionner un article!");// Affichage d'un message si erreur
            }
        }

        /// <summary>
        /// Fonction Load du formulaire
        /// </summary>
        private void FormPlats_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // Desactivation du ControlBox
        }

        /// <summary>
        /// Fonction Click du bouton Acceuil
        /// </summary>
        private void btAcceuil_Click(object sender, EventArgs e)
        {
          this.Close(); // Fermeture du formulaire
        }
  }
}
