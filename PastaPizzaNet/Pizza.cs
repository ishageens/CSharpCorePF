using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PastaPizzaNet
{
    public class Pizza : Gerecht
    {
        public Pizza(string naam, decimal prijs, List<string> onderdelen) : base(naam, prijs)
        {
            Onderdelen = onderdelen;
        }
        public List<string> Onderdelen { get; set; }

        public override decimal BerekenBedrag()
        {
            decimal pizzaPrijs = this.StandaardPrijs;
            return pizzaPrijs;
        }

        public override string ToString()
        {
            StringBuilder pizzastring = new StringBuilder(base.ToString());
            foreach (var onderdeel in Onderdelen)
            {
                pizzastring.Append(onderdeel.ToString());
                if (Onderdelen.IndexOf(onderdeel) != Onderdelen.Count - 1)
                    pizzastring.Append(" - ");
            }
            return pizzastring.ToString();
        }
    }
}
