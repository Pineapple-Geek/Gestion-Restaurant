using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
    public partial class Article
    {

        /// <summary>
        /// ajoute un Article
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool AddArticle(Article article)
        {
            bool ok;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {
                try
                {
                    //ajoute le user a l entitee
                    bdd.Article.Add(article);
                    //save les modifs dans la base
                    bdd.SaveChanges();
                    ok = true;
                }
                catch (Exception)
                {
                    ok = false;
                }
            }
            return ok;
        }


        /// <summary>
        /// recup un article a partir de son identifiant
        /// </summary>
        /// <param name="unIDarticle">id de l'article recherché</param>
        /// <returns>user qu on recherche et si il existe pas un nouveau article</returns>

        public static Article GetInstance(int unIdArticle)
        {
            Article unArticle;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {
               
                try
                {
                    
                    unArticle = bdd.Article.Where(x => x.idArticle == unIdArticle).FirstOrDefault();
                }
                catch (Exception)
                {
                    unArticle = new Article();
                }
            }
            return unArticle;
        }

        /// <summary>
        /// recup la liste des article
        /// </summary>
       /// <returns>la liste des articles qu on recherche et si il existe pas une liste vide</returns>

        public static List<Article> GetArticle()
        {
            List<Article> DesArticles;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {
                    
                    DesArticles = bdd.Article.ToList();
                }
                catch (Exception)
                {
                    DesArticles = new List<Article>();
                }
            }
            return DesArticles;
        }



        /// <summary>
        /// maj article
        /// </summary></returns>

        /// <returns>indique si l action a reussi
        public static bool UpdateArticle(Article ArticleToUpdate)
        {
            bool ok;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {
                    //maj de l'atrticle ds l entitee
                    Article unArticle = bdd.Article.Where(x => x.idArticle == ArticleToUpdate.idArticle).FirstOrDefault();

                    unArticle.designationArticle = ArticleToUpdate.designationArticle;
                    unArticle.prixArticle = ArticleToUpdate.prixArticle;
                    unArticle.photoArticle = ArticleToUpdate.photoArticle;
                    unArticle.idCatArticle = ArticleToUpdate.idCatArticle;

                    //save les modifs dans la base
                    bdd.SaveChanges();
                    ok = true;
                }
                catch (Exception)
                {
                    ok = false;
                }
            }
            return ok;
        }


        /// <summary>
        /// supp l article
        /// </summary></returns>
        
        /// <returns>indique si l action a reussi
        public static bool DeleteArticle(Article ArticleToDelete)
        {
            bool ok;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {
                    //maj de l'article ds l entitee
                    Article unArticle = bdd.Article.Where(x => x.idArticle == ArticleToDelete.idArticle).FirstOrDefault();
                    bdd.Article.Remove(unArticle);
                                       //save les modifs dans la base
                    bdd.SaveChanges();
                    ok = true;
                }
                catch (Exception)
                {
                    ok = false;
                }
            }
            return ok;
        }


        internal static List<Article> GetArticleByCateg(int idCat)
        {
            List<Article> DesArticles;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {

                    DesArticles = bdd.Article.Where(x => x.idCatArticle == idCat).ToList();
                }
                catch (Exception)
                {
                    DesArticles = new List<Article>();
                }
            }
            return DesArticles;
        }
    }
}

