using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Emprunt
    {
        public int identification { get; }
        public DateTime DateDebut { get; }
        public DateTime DateRetour { get; }
        public DateTime DateRetourEffective { get; set; }
        public Livre livreEmprunte { get; }
        public Abonne AbonneEmprunteur {  get; }
        public Emprunt(int identification,Abonne abonne, Livre livre)
        {
            livreEmprunte = livre;

            if (!livre.EstDisponible)
            {
                Console.WriteLine("Ce livre est déjà emprunté!");
            }

            this.identification = identification;
            AbonneEmprunteur = abonne;
            DateDebut = DateTime.Now;
            DateRetour = DateDebut.AddDays(14); //Prêt de 14 jours
        }
    }
}
