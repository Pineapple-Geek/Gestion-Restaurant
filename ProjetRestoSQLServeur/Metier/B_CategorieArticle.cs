using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
    class B_CategorieArticle
    {
        public B_CategorieArticle(int unIdCatArticle, String unLibelleCatArticle)
        {
            CategorieArticle uneCategorieArticle = new CategorieArticle();
            uneCategorieArticle.idCatArticle = unIdCatArticle;
            uneCategorieArticle.libelleCatArticle = unLibelleCatArticle;
            
            CategorieArticle.AddCategorieArticle(uneCategorieArticle);
        }
        public static void Delete(int unIdCatArticle)
        {
            CategorieArticle uneCatArticle = new CategorieArticle();
            uneCatArticle.idCatArticle = unIdCatArticle;
            CategorieArticle.DeleteCategorieArticle(uneCatArticle);
        }
        public static void Add(String unLibelleCatArticle)
        {
            CategorieArticle uneCategorieArticle = new CategorieArticle();
            uneCategorieArticle.libelleCatArticle = unLibelleCatArticle;
            CategorieArticle.AddCategorieArticle(uneCategorieArticle);
        }

        public static void Update(int unIdCat, String unLibelle)
        {
            CategorieArticle uneCat = CategorieArticle.GetInstance(unIdCat);
            uneCat.libelleCatArticle = unLibelle;
            CategorieArticle.UpdateCategorieArticle(uneCat);
        }

    }
}
