using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    class Frisdrank : Drank
    {
        private DrankenLijst naamValue;
        public DrankenLijst Naam
        {
            get
            {
                return naamValue;
            }

            set
            {
                naamValue = value;
            }
        }
        public const decimal frisdrankPrijs = 2m;

        public Frisdrank(DrankenLijst naam) : base(naam)
        {
        }

        public override decimal Prijs
        {
            get => frisdrankPrijs;
        }

        public override string ToString() => base.ToString();
    }
}
