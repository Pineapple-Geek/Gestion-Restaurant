using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
  public partial class Commande
  {
    /// <summary>
    /// ajoute une Table
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public static bool AddCommande(Commande Commande)
    {
      bool ok;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {
        try
        {
          //ajoute le user a l entitee
          bdd.Commande.Add(Commande);
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
    /// recup un Table a partir de son numéro
    /// </summary>
    /// <param name="unIDCommande">id de la Table recherché</param>
    /// <returns></returns>

    public static Commande GetInstance(int unIdCommande)
    {
      Commande unCommande;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {

          unCommande = bdd.Commande.Where(x => x.numCommande == unIdCommande).FirstOrDefault();
        }
        catch (Exception)
        {
          unCommande = new Commande();
        }
      }
      return unCommande;
    }

    /// <summary>
    /// recup la liste des Commande
    /// </summary>
    /// <returns>la liste des Table qu on recherche et si il existe pas une liste vide</returns>

    public static List<Commande> GetCommande()
    {
      List<Commande> DesCommandes;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {

          DesCommandes = bdd.Commande.ToList();
        }
        catch (Exception)
        {
          DesCommandes = new List<Commande>();
        }
      }
      return DesCommandes;
    }



    /// <summary>
    /// maj Table
    /// </summary>

    /// <returns>indique si l action a reussi</returns>
    public static bool UpdateCommande(Commande CommandeToUpdate)
    {
      bool ok;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {
          //maj de l'atrticle ds l entitee
          Commande unCommande = bdd.Commande.Where(x => x.numCommande == CommandeToUpdate.numCommande).FirstOrDefault();

          unCommande.dateHeureCommance = CommandeToUpdate.dateHeureCommance;
          unCommande.numTablee = CommandeToUpdate.numTablee;
          unCommande.idServeur = CommandeToUpdate.idServeur;
          unCommande.termine = CommandeToUpdate.termine;

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
    /// supp l Table
    /// </summary>

    /// <returns>indique si l action a reussi</returns>
    public static bool TermineCommande(Commande CommandeToTermine)
    {
      bool ok;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {
          //maj de l'Commande ds l entitee
          Commande unCommande = bdd.Commande.Where(x => x.numCommande == CommandeToTermine.numCommande).FirstOrDefault();
          unCommande.termine = CommandeToTermine.termine;
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
  }
}
