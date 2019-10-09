using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
   public partial class CategorieArticle
    {

        /// <summary>
        /// ajoute un CategorieArticle
        /// </summary>
  
       public static bool AddCategorieArticle(CategorieArticle categorieArticle)
        {
            bool ok;
            using (BDDRestaurantEntities Bdd = new BDDRestaurantEntities())
            {
                try
                {
                    //ajoute le categorieArticle a l entitee
                    Bdd.CategorieArticle.Add(categorieArticle); //.AddObject(categorieArticle);

                    //save les modifs dans la base
                    Bdd.SaveChanges();
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
        /// recup une catarticle a partir de son id
        /// </summary>
  
        /// <returns>catArticle qu on recherche et si il existe pas un nv catarticle0</returns>

       public static CategorieArticle GetInstance(int unIdCatArticle)
        {
            CategorieArticle uneCategorieArticle;
            using (BDDRestaurantEntities Bdd = new BDDRestaurantEntities())
            {
               
                try
                {
                    //select * from daluser where daluserid=iduser;
                    uneCategorieArticle = Bdd.CategorieArticle.Where(x => x.idCatArticle == unIdCatArticle).FirstOrDefault();
                }
                catch (Exception)
                {
                    uneCategorieArticle = new CategorieArticle();
                }
            }
            return uneCategorieArticle;
        }

        /// <summary>
       /// recup la liste des CategorieArticle
        /// </summary>
       /// <returns>la liste des CategorieArticle qu on recherche et si il existe pas une liste vide</returns>

       public static List<CategorieArticle> GetCategorieArticle()
        {
            List<CategorieArticle> DesCategorieArticles;
            using (BDDRestaurantEntities Bdd = new BDDRestaurantEntities())
            {

                try
                {
                    //select * from daluser where Article=iduser;
                    DesCategorieArticles = Bdd.CategorieArticle.ToList();
                }
                catch (Exception)
                {
                    DesCategorieArticles = new List<CategorieArticle>();
                }
            }
            return DesCategorieArticles;
        }



        /// <summary>
       /// maj CategorieArticle
        /// </summary></returns>

        /// <returns>indique si l action a reussi
       public static bool UpdateCategorieArticle(CategorieArticle CategorieArticleToUpdate)
        {
            bool ok;
            using (BDDRestaurantEntities Bdd = new BDDRestaurantEntities())
            {

                try
                {
                    //maj du user ds l entitee
                    CategorieArticle unArticle = Bdd.CategorieArticle.Where(x => x.idCatArticle == CategorieArticleToUpdate.idCatArticle).FirstOrDefault();

                    unArticle.idCatArticle = CategorieArticleToUpdate.idCatArticle;
                    unArticle.libelleCatArticle = CategorieArticleToUpdate.libelleCatArticle;


                    //save les modifs dans la base
                    Bdd.SaveChanges();
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
       /// supp CategorieArticle
        /// </summary></returns>
       /// CategorieArticleToDelete =user a supp
        /// <returns>indique si l action a reussi
       public static bool DeleteCategorieArticle(CategorieArticle CategorieArticleToDelete)
       {
            bool ok;
            using (BDDRestaurantEntities Bdd = new BDDRestaurantEntities())
            {

                try
                {
                    //maj du user ds l entitee
                    CategorieArticle unCategorieArticle = Bdd.CategorieArticle.Where(x => x.idCatArticle == CategorieArticleToDelete.idCatArticle).FirstOrDefault();
                    //Bdd.DeleteObject(unCategorieArticle);
                    Bdd.CategorieArticle.Remove(unCategorieArticle);

                    //save les modifs dans la base
                    Bdd.SaveChanges();
                    ok = true;
                }
                catch (Exception)
                {
                    ok = false;
                }
            }
            return ok;
       }

       public static List<CategorieArticle> GetCategoriePlats()
       {
           List<CategorieArticle> DesCategorieArticles;
            using (BDDRestaurantEntities Bdd = new BDDRestaurantEntities())

                try
               {
                   DesCategorieArticles = Bdd.CategorieArticle.Where(x => x.idCatArticle != 0).ToList();
               }
               catch (Exception)
               {
                   DesCategorieArticles = new List<CategorieArticle>();
               }
           return DesCategorieArticles;
       }

    }
}

