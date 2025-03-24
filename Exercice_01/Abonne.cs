using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Abonne
    {
        public int Id { get; }
        public string Nom {  get; }
        public string Prenom { get; }
        public string Email { get; }
        List<Emprunt> emprunts;

        //Constructeur 
        public Abonne(int id, string nom, string prenom, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            emprunts = new List<Emprunt>(); //Liste d'emprunts de l'abonné
        }

        public bool PeutEmprunter()
        {
            if (emprunts.Count < 3)
            {
                return true;    
            }
            else
            {
                return false;
            }
        }

        public void AjouterEmprunt(Emprunt emprunt)
        {
            if (PeutEmprunter())
            {
                emprunts.Add(emprunt);
            }
            else
            {
                Console.WriteLine("L'abonné a déjà emprunté 3 livres");
            }
        }

        public void RetournerLivre(Livre livre)
        {
            Emprunt empruntaretourner = null;
            //Rechercher le livre dans la liste des emprunts de l'abonné
            for (int i = 0; i < emprunts.Count; i++)
            {
                if (emprunts[i].livreEmprunte == livre)
                {
                    empruntaretourner = emprunts[i];
                    break; //Arret de la boucle for
                }
            }

            if (empruntaretourner != null)
            {
                empruntaretourner.DateRetourEffective = DateTime.Now;
                emprunts.Remove(empruntaretourner);
                Console.WriteLine($"Le livre {livre.Titre} a été retourné!");
            }
            else
            {
                Console.WriteLine("Ce livre n'a pas été emprunté par cet abonné");
            }
        }
    }
}
