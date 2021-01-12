using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    class Brouwer
    {

        public int BrouwerNr { get; set; }
        public string Brouwernaam { get; set; }
        public bool Belgisch { get; set; }

        public List<Bier> Bieren { get; set; }

        public override string ToString()
        {
            return $"Brouwerij {Brouwernaam} ({(Belgisch ? "Belgisch" : "Niet Belgisch")})";
        }
    }
}
