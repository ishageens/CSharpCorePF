using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Spaarrekening.Intrest = 3m;

                Klant ik = new Klant("Piet", "Pienter");

                ISpaarmiddel[] spaarmiddelen = new ISpaarmiddel[3];
                spaarmiddelen[0] = new Zichtrekening("BE40747524091936", 14.51m, DateTime.Today, ik, -500m);
                spaarmiddelen[1] = new Spaarrekening("BE40645100000163", 1000m, DateTime.Today, ik);
                spaarmiddelen[2] = new Kasbon(DateTime.Today, 1000m, 5, 3.5m, ik);
                foreach (ISpaarmiddel spaarmiddel in spaarmiddelen)
                    spaarmiddel.Afbeelden();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
