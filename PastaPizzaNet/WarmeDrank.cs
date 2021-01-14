using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    class WarmeDrank : Drank
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
        public const decimal warmedrankPrijs = 2.5m;

        public override decimal Prijs
        {
            get => warmedrankPrijs;
        }

        public WarmeDrank(DrankenLijst naam) : base(naam)
        {
            Naam = naam;
        }

        public override string ToString() => base.ToString();
    }
}
