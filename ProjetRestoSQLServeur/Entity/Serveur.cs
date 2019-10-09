using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
    public partial class Serveur
  {

        /// <summary>
        /// ajoute un Serveur
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool AddServeur(Serveur serveur)
        {
            bool ok;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {
                try
                {
                    //ajoute le user a l entitee
                    bdd.Serveur.Add(serveur);
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
        /// recup un Serveur a partir de son identifiant
        /// </summary>
        /// <param name="unIDServeur">id de l'Serveur recherché</param>
        /// <returns>user qu on recherche et si il existe pas un nouveau Serveur</returns>

        public static Serveur GetInstance(int unIdServeur)
        {
            Serveur unServeur;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {
               
                try
                {
                    
                    unServeur = bdd.Serveur.Where(x => x.idServeur == unIdServeur).FirstOrDefault();
                }
                catch (Exception)
                {
                    unServeur = new Serveur();
                }
            }
            return unServeur;
        }

        /// <summary>
        /// recup la liste des Serveur
        /// </summary>
       /// <returns>la liste des Serveurs qu on recherche et si il existe pas une liste vide</returns>

        public static List<Serveur> GetServeur()
        {
            List<Serveur> DesServeurs;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {
                    
                    DesServeurs = bdd.Serveur.ToList();
                }
                catch (Exception)
                {
                    DesServeurs = new List<Serveur>();
                }
            }
            return DesServeurs;
        }



        /// <summary>
        /// maj Serveur
        /// </summary></returns>

        /// <returns>indique si l action a reussi
        public static bool UpdateServeur(Serveur ServeurToUpdate)
        {
            bool ok;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {
                    //maj de l'atrticle ds l entitee
                    Serveur unServeur = bdd.Serveur.Where(x => x.idServeur == ServeurToUpdate.idServeur).FirstOrDefault();

                    unServeur.nomServeur = ServeurToUpdate.nomServeur;
                    unServeur.prenomServeur = ServeurToUpdate.prenomServeur;
                    unServeur.actif = ServeurToUpdate.actif;
                    unServeur.idServeur = ServeurToUpdate.idServeur;

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
        /// supp l Serveur
        /// </summary></returns>
        
        /// <returns>indique si l action a reussi
        public static bool DeleteServeur(Serveur ServeurToDelete)
        {
            bool ok;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {
                    //maj de l'Serveur ds l entitee
                    Serveur unServeur = bdd.Serveur.Where(x => x.idServeur == ServeurToDelete.idServeur).FirstOrDefault();
                    bdd.Serveur.Remove(unServeur);
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


        internal static List<Serveur> GetServeurByCateg(int idCat)
        {
            List<Serveur> DesServeurs;
            using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
            {

                try
                {

                    DesServeurs = bdd.Serveur.Where(x => x.idServeur == idCat).ToList();
                }
                catch (Exception)
                {
                    DesServeurs = new List<Serveur>();
                }
            }
            return DesServeurs;
        }
    }
}

