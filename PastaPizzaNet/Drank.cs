using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public abstract class Drank : IBedrag
    {
        public DrankenLijst Naam { get; set; }

        private decimal prijsValue;
        public virtual decimal Prijs
        {
            get
            {
                return prijsValue;
            }
        }

        public Drank(DrankenLijst naam)
        {
            Naam = naam;
        }


        public override string ToString() => $"Drank: {Naam} ({Prijs} euro)";

        public decimal BerekenBedrag()
        {
            return Prijs;
        }
    }
}
