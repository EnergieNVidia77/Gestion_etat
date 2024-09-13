using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            ObjetMetier objet = new ObjetMetier(Etat.Attente, "Commande en Attente");
            objet.ChangertEtat(Etat.Envoye, "Colis Envoyé");
            objet.ChangertEtat(Etat.Recu, "Colis Reçu");
            objet.ChangertEtat(Etat.Termine, "Statut Terminé");
            //objet.ChangertEtat(Etat.Termine, "Statut Terminé");
            objet.PrintHistorique();
        }
    }
}