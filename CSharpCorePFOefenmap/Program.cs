using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Klant klant1 = new Klant("Jos", "Verhoeven");
            ISpaarmiddel[] rekeningen = new ISpaarmiddel[3];
            rekeningen[0] = new Spaarrekening("BE19731021964512", 100, DateTime.Today, klant1);
            rekeningen[1] = new Zichtrekening("BE19731021964512", 200, DateTime.Today, klant1, -750);
            rekeningen[2] = new Kasbon(DateTime.Today, 1000, 2, 1, klant1);
            foreach (ISpaarmiddel rekening in rekeningen)
                rekening.Afbeelden();
        }
    }
}
