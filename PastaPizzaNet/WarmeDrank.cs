using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public class WarmeDrank : Drank
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
                //validatie van enum lukt me niet
                naamValue = value;
            }
        }

        private const decimal warmedrankPrijs = 2.5m;

        public override decimal Prijs
        {
            get
            {
                return warmedrankPrijs;
            }
        }

        public WarmeDrank(DrankenLijst naam) : base(naam)
        {
            Naam = naam;
        }

        public override string ToString() => base.ToString();
    }
}
