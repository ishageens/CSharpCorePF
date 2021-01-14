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
        public Extras? Extras { get; set; }
        public BesteldGerecht(Gerecht gerecht, Grootte grootte, Extras? extras = null, Extras? extras1 = null, Extras? extras2 = null)
        {
            this.GevraagdGerecht = gerecht;
            this.Grootte = grootte;
            this.Extras = extras;
            this.Extras = extras1;
            this.Extras = extras2;
        }

        public override string ToString() => GevraagdGerecht.ToString() + $"({Grootte}) {Extras}";

        public decimal BerekenBedrag()
        {
            decimal besteldGerechtPrijs = 2;
            if (this.Grootte == Grootte.Groot)
                besteldGerechtPrijs += 3;
            return besteldGerechtPrijs;
        }
    }
}
