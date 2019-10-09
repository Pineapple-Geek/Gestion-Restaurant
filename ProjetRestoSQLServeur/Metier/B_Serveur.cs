using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetRestoSQLServeur
{
    public class B_Serveur
    {
        public B_Serveur(int unIdServeur, String unNomServeur, String unPrenomServeur, bool unActif)
        {
            Serveur unServeur = new Serveur();
            unServeur.idServeur = unIdServeur;
            unServeur.nomServeur = unNomServeur;
            unServeur.prenomServeur = unPrenomServeur;
            unServeur.actif = unActif;

            Serveur.AddServeur(unServeur);
        }

        public static void Delete(int unIdServeur)
        {
            Serveur unServeur = new Serveur();
            unServeur.idServeur = unIdServeur;
            Serveur.DeleteServeur(unServeur);
        }

        public static void Add(String unNomServeur, String unPrenomServeur, bool unActif)
        {
            Serveur unServeur = new Serveur( ) ;
            unServeur.nomServeur = unNomServeur;
            unServeur.prenomServeur = unPrenomServeur;
            unServeur.actif = unActif;
            Serveur.AddServeur(unServeur);
        }

        public static void Update(int unIdServeur, String unNomServeur, String unPrenomServeur, bool unActif)
        {
            Serveur unServeur = Serveur.GetInstance(unIdServeur);
            unServeur.idServeur = unIdServeur;
            unServeur.nomServeur = unNomServeur;
            unServeur.prenomServeur = unPrenomServeur;
            unServeur.actif = unActif;
            Serveur.UpdateServeur(unServeur);
        }

    }
}
