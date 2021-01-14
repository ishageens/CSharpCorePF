using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    class Bestelling
    {
        private Klant klantValue;
        public Klant Klant
        {
            get
            {
                return klantValue;
            }
            set
            {
                klantValue = value;
            }
        }

        public BesteldGerecht BesteldGerecht { get; set; }
        public Drank Drank { get; set; }
        public Dessert Dessert { get; set; }
        public int Aantal { get; set; }

        public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank drank, Dessert dessert, int aantal = 1)
        {
            Klant = klant;
            BesteldGerecht = besteldGerecht;
            Drank = drank;
            Dessert = dessert;
            Aantal = aantal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Klant.ToString());
            sb.AppendLine(BesteldGerecht.ToString());
            sb.AppendLine(Drank.ToString());
            sb.AppendLine(Dessert.ToString());
            sb.AppendLine($"Aantal: {Aantal}");
            return sb.ToString();
        }
    }
}
