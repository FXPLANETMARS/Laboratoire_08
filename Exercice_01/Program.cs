using System.Diagnostics.Contracts;

namespace Exercice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abonne abonne1 = new Abonne(145, "Lise", "Pauline", "Lise@gmail.com");
            Livre livre1 = new Livre(49, "La princesse de Paris", "Antoine Lafontaine", "Conte");
            Livre livre2 = new Livre(89, "Le monument", "Paris Dagenais", "Western");

            //Emprunt d'un livre
            if (abonne1.PeutEmprunter())
            {
                Emprunt emprunt1 = new Emprunt(1, abonne1, livre1);
                abonne1.AjouterEmprunt(emprunt1);
                Console.WriteLine($"Le livre {livre1.Titre} emprunté par {abonne1.Prenom} {abonne1.Nom}");

            }


            //Faire un retour
            abonne1.RetournerLivre(livre1);

        }
    }
}
