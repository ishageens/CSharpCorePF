using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    class Dessert : IBedrag
    {
        public DessertenLijst Naam { get; set; }

        private decimal prijsValue;
        public decimal Prijs
        {
            get
            {
                if ((int)Naam == 2)
                    prijsValue = 2;
                else prijsValue = 3;
                return prijsValue;

            }
        }
        //Tiramisu en Ijs = €3
        // Cake = €2

        public Dessert(DessertenLijst naam)
        {
            Naam = naam;
        }
        public override string ToString() => $"Dessert: {Naam} ({Prijs} euro)";

        public decimal BerekenBedrag()
        {
            decimal dessertPrijs = this.Prijs;
            return dessertPrijs;
        }
    }
}
