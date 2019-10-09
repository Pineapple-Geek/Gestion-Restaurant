using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRestoSQLServeur
{
  public class B_Tablee
  {
    public B_Tablee(int unNumTablee, int unNbPlaceTablee)
    {
      Tablee unTablee = new Tablee();
      unTablee.numTablee = unNumTablee;
      unTablee.numTablee = unNbPlaceTablee;

      Tablee.AddTablee(unTablee);
    }

    public static void Delete(int unNumTablee)
    {
      Tablee unTablee = new Tablee();
      unTablee.numTablee = unNumTablee;
      Tablee.DeleteTablee(unTablee);
    }

    public static void Add(int unNbPlaceTablee)
    {
      Tablee unTablee = new Tablee(); ;
      unTablee.nbPlaceTablee = unNbPlaceTablee;
      Tablee.AddTablee(unTablee);
    }

    public static void Update(int unNumTablee, int unNbPlaceTablee)
    {
      Tablee unServeur = Tablee.GetInstance(unNumTablee);
      unServeur.numTablee = unNumTablee;
      unServeur.nbPlaceTablee = unNbPlaceTablee;
      Tablee.UpdateTablee(unServeur);
    }
  }
}
