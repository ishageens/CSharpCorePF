using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    public class Afdeling
    {
        public const int Verdiepingen = 10;
        public Afdeling(string naam, int verdieping)
        {
            Naam = naam;
            Verdieping = verdieping;
        }
        public string Naam { get; set; }

        private int verdiepingValue;
        public int Verdieping
        {
            get
            {
                return verdiepingValue;
            }
            set
            {
                if (value >= 0 && value <= Verdiepingen)
                    verdiepingValue = value;
            }
        }
        public override string ToString()
        {
            return $"Afdeling: {Naam} op verdieping {Verdieping}";

        }
    }
}
