using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public class Frisdrank : Drank
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

        private const decimal frisdrankPrijs = 2m;

        public override decimal Prijs
        {
            get { return frisdrankPrijs; }
        }
        public Frisdrank(DrankenLijst naam) : base(naam)
        {
        }


        public override string ToString() => base.ToString();
    }
}
