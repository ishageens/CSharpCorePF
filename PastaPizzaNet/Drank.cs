using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public class Drank : IBedrag
    {
        public DrankenLijst Naam { get; set; }

        public virtual decimal Prijs { get; }

        public Drank(DrankenLijst naam)
        {
            Naam = naam;
        }


        public override string ToString() => $"Drank: {Naam} ({Prijs} euro)";

        public decimal BerekenBedrag()
        {
            decimal drankPrijs = this.Prijs;
            return drankPrijs;
        }
    }
}
