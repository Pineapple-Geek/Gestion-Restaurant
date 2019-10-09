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
    public partial class FormArticleCarteModif : Form
  {
        public FormArticleCarteModif()
        {
            InitializeComponent();
        }

        public FormArticleCarteModif(int unId)
        {
            InitializeComponent();
            Init(unId);
        }

        public void Init(int unId)
        {
            Article unArticle = Article.GetInstance(unId);

            TB_Nom_Plat.Text = unArticle.designationArticle.ToString();
            TB_Photo_Plat.Text = unArticle.photoArticle.ToString();
            TB_Prix_Plat.Text = unArticle.prixArticle.ToString();
            TB_Id_Plat.Text = unArticle.idArticle.ToString();
            CB_Type_Plats.SelectedValue = unArticle.idCatArticle.ToString();
           

            List<CategorieArticle> uneCatArticle;
            uneCatArticle = CategorieArticle.GetCategoriePlats();
            CB_Type_Plats.DataSource = uneCatArticle;
            CB_Type_Plats.ValueMember = "idCatArticle";
            CB_Type_Plats.DisplayMember = "libelleCatArticle";
            //CB_Type_Plats.SelectedValue = CategorieArticle.GetInstance(Convert.ToInt32(unArticle.idCatArticle));
            //-------------------------------------------------------------------------------------------------
            CategorieArticle LaCategorie = CategorieArticle.GetInstance(Convert.ToInt32(unArticle.idCatArticle));
            CB_Type_Plats.Text =  LaCategorie.libelleCatArticle;
            CB_Type_Plats.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void B_ModifFin_Click(object sender, EventArgs e)
        {
            int unId;
            string unNom;
            string unePhoto;
            int unPrix;
            int unIdCat;
            unId = Convert.ToInt32(TB_Id_Plat.Text);
            unNom = TB_Nom_Plat.Text;
            unePhoto = TB_Photo_Plat.Text;
            unPrix = Convert.ToInt32(TB_Prix_Plat.Text);
            unIdCat = Convert.ToInt32(CB_Type_Plats.SelectedValue);
            B_Article.Update(unId, unNom, unPrix, unePhoto, unIdCat);
            this.Close();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormArticleCarteModif_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
