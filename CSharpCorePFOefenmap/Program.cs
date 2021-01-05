using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Klant klant1 = new Klant("Jos", "Verhoeven");
            Spaarrekening spaar = new Spaarrekening("BE19731021964512", 100, DateTime.Today, klant1);
            Zichtrekening zicht = new Zichtrekening("BE19731021964512", 200, DateTime.Today, klant1, -750);
            spaar.Afbeelden();
            zicht.Afbeelden();
        }
    }
}
