using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRestoSQLServeur
{
  public class B_Commande
  {
    public B_Commande(int unNumTablee, int unIdServeur)
    {
      Commande unCommande = new Commande();
      unCommande.dateHeureCommance = DateTime.Now;
      unCommande.numTablee = unNumTablee;
      unCommande.idServeur = unIdServeur;
      unCommande.termine = false;

      Commande.AddCommande(unCommande);
    }

    public static void Delete(int unNumCommande, bool unTermine)
    {
      Commande unCommande = new Commande();
      unCommande.numCommande = unNumCommande;
      unCommande.termine = unTermine;
      Commande.TermineCommande(unCommande);
    }

    public static void Add(int unNumTablee, int unIdServeur)
    {
      Commande unCommande = new Commande();
      unCommande.dateHeureCommance = DateTime.Now;
      unCommande.numTablee = unNumTablee;
      unCommande.idServeur = unIdServeur;
      unCommande.termine = false;

      Commande.AddCommande(unCommande);
    }

    public static void Update(int unNumCommande, int unNumTablee, int unIdServeur, bool unTermine)
    {
      Commande unCommande = Commande.GetInstance(unNumCommande);
      unCommande.numTablee = unNumTablee;
      unCommande.idServeur = unIdServeur;
      unCommande.termine = unTermine;
      Commande.UpdateCommande(unCommande);
    }
  }
}
