using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    class Klant
    {
        public int KlantID { get; set; }
        public string Naam { get; set; }

        public Klant(int klantId, string naam)
        {
            KlantID = klantId;
            Naam = naam;
        }

        public override string ToString() => $"Klant: {Naam}";
    }
}
