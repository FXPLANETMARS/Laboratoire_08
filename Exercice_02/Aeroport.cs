using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_02
{
    internal class Aeroport
    {
        public string NomAeroport {  get; set; }
        public string Localisation { get; set; }


        public void Atterrir(string nomAeroport, string localisation)
        {
            Console.WriteLine("Le véhicule aérien attérit");
        }

        public void Decoller()
        {
            Console.WriteLine("Le véhicule aérien décolle");
        }
    }
}
