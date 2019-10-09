using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
    public class B_Article
    {
        public B_Article(int unIdArticle, int unIdCatArticle, String uneDesignationArticle, float unPrixArticle, String unePhotoArticle)
        {
            Article unArticle = new Article();
            unArticle.idArticle = unIdArticle;
            unArticle.designationArticle = uneDesignationArticle;
            unArticle.prixArticle = unPrixArticle;
            unArticle.photoArticle = unePhotoArticle;
            unArticle.idCatArticle = unIdCatArticle;

            Article.AddArticle(unArticle);
        }

        public static void Delete(int unIdArticle)
        {
            Article unArticle = new Article();
            unArticle.idArticle = unIdArticle;
            Article.DeleteArticle(unArticle);
        }

        public static void Add(String uneDesignationArticle, int unPrixArticle, String unePhotoArticle, int unIdCatArticle)
        {
            Article unArticle = new Article( ) ;
            unArticle.designationArticle = uneDesignationArticle;
            unArticle.prixArticle = unPrixArticle;
            unArticle.photoArticle = unePhotoArticle;
            unArticle.idCatArticle = unIdCatArticle;
            Article.AddArticle(unArticle);
        }

        public static void Update(int unId, String uneDesignationArticle, int unPrixArticle, String unePhotoArticle, int unIdCatArticle)
        {
            Article unArticle = Article.GetInstance(unId);
            unArticle.designationArticle = uneDesignationArticle;
            unArticle.prixArticle = unPrixArticle;
            unArticle.photoArticle = unePhotoArticle;
            unArticle.idCatArticle = unIdCatArticle;
            Article.UpdateArticle(unArticle);
        }

    }
}
