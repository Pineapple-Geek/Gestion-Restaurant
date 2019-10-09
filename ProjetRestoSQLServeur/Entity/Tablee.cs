using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
  public partial class Tablee
  {
    /// <summary>
    /// ajoute une Table
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public static bool AddTablee(Tablee Tablee)
    {
      bool ok;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {
        try
        {
          //ajoute le user a l entitee
          bdd.Tablee.Add(Tablee);
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
    /// <param name="unIDTablee">id de la Table recherché</param>
    /// <returns></returns>

    public static Tablee GetInstance(int unIdTablee)
    {
      Tablee unTablee;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {

          unTablee = bdd.Tablee.Where(x => x.numTablee == unIdTablee).FirstOrDefault();
        }
        catch (Exception)
        {
          unTablee = new Tablee();
        }
      }
      return unTablee;
    }

    /// <summary>
    /// recup la liste des Tablee
    /// </summary>
    /// <returns>la liste des Table qu on recherche et si il existe pas une liste vide</returns>

    public static List<Tablee> GetTablee()
    {
      List<Tablee> DesTablees;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {

          DesTablees = bdd.Tablee.ToList();
        }
        catch (Exception)
        {
          DesTablees = new List<Tablee>();
        }
      }
      return DesTablees;
    }



    /// <summary>
    /// maj Table
    /// </summary>

    /// <returns>indique si l action a reussi</returns>
    public static bool UpdateTablee(Tablee TableeToUpdate)
    {
      bool ok;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {
          //maj de l'atrticle ds l entitee
          Tablee unTablee = bdd.Tablee.Where(x => x.numTablee == TableeToUpdate.numTablee).FirstOrDefault();

          unTablee.numTablee = TableeToUpdate.numTablee;
          unTablee.nbPlaceTablee = TableeToUpdate.nbPlaceTablee;

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
    public static bool DeleteTablee(Tablee TableeToDelete)
    {
      bool ok;
      using (BDDRestaurantEntities bdd = new BDDRestaurantEntities())
      {

        try
        {
          //maj de l'Tablee ds l entitee
          Tablee unTablee = bdd.Tablee.Where(x => x.numTablee == TableeToDelete.numTablee).FirstOrDefault();
          bdd.Tablee.Remove(unTablee);
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
