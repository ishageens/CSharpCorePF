using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public class BesteldGerecht : IBedrag
    {
        public Gerecht GevraagdGerecht
        {
            get; set;
        }
        public Grootte Grootte { get; set; }
        public List<Extras>? Extras { get; set; }
        public BesteldGerecht(Gerecht gerecht, Grootte grootte, List<Extras>? extras = null)
        {
            GevraagdGerecht = gerecht;
            Grootte = grootte;
            Extras = extras;


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(GevraagdGerecht.ToString());
            sb.Append($" ({Grootte}) ");
            if (Extras.Count != 0)
            {
                sb.Append($" extra: ");
                foreach (var extra in Extras)
                    sb.Append($"{extra} ");
            }
            sb.Append($" ({this.BerekenBedrag()} euro)");
            return sb.ToString();
        }

        public decimal BerekenBedrag()
        {
            decimal besteldGerechtPrijs = GevraagdGerecht.StandaardPrijs;
            if (this.Grootte == Grootte.Groot)
                besteldGerechtPrijs += 3;
            if (Extras.Count != 0)
            {
                foreach (var extra in Extras)
                    besteldGerechtPrijs += 1;
            }
            return besteldGerechtPrijs;
        }
    }
}
