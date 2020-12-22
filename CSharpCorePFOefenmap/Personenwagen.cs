using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Personenwagen : Voertuig
    {
        public Personenwagen() : base()
        {
            AantalDeuren = 4;
            AantalPassagiers = 5;
        }

        public Personenwagen(string polisHouder, decimal kostprijs, int pk, float gemVerbruik, string nummerPlaat, int deuren, int passagiers) : base(polisHouder, kostprijs, pk, gemVerbruik, nummerPlaat)
        {
            AantalDeuren = deuren;
            AantalPassagiers = passagiers;
        }

        private int aantalDeurenValue;
        public int AantalDeuren
        {
            get { return aantalDeurenValue; }
            set
            {
                if (value >= 0)
                    aantalDeurenValue = value;
            }
        }

        private int aantalPassagiersValue;
        public int AantalPassagiers
        {
            get { return aantalPassagiersValue; }
            set
            {
                if (value >= 0)
                    aantalPassagiersValue = value;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Aantal deuren: {AantalDeuren}");
            Console.WriteLine($"Aantal passagiers: {AantalPassagiers}");
        }
    }
}
