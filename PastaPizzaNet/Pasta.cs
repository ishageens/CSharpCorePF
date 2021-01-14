using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public class Pasta : Gerecht
    {
        public Pasta(string naam, decimal prijs, string omschrijving) : base(naam, prijs)
        {
            Omschrijving = omschrijving;
        }

        public string Omschrijving { get; set; }

        public override decimal BerekenBedrag()
        {
            decimal pastaPrijs = this.StandaardPrijs;
            return pastaPrijs;
        }

        public override string ToString() => base.ToString() + $"{Omschrijving}";
    }
}
