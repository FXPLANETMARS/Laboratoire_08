using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Livre
    {
        public int code { get; }
        public string Titre {  get;}
        public string Auteur { get; }
        public string Genre { get; }
        public bool EstDisponible { get; set; } = true;
        public Livre (int code, string titre, string auteur,string genre)
        {
            this.code = code;
            Titre = titre;
            Auteur = auteur;
            Genre = genre;
        }
    }
}
