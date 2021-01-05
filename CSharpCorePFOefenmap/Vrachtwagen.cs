using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Vrachtwagen : Voertuig
    {
        public Vrachtwagen() : base()
        {
            MaximumLading = 10000f;
        }

        public Vrachtwagen(string polisHouder, decimal kostprijs, int pk, float gemVerbruik, string nummerPlaat, float maximumLading) : base(polisHouder, kostprijs, pk, gemVerbruik, nummerPlaat)
        {
            MaximumLading = maximumLading;
        }

        private float maxLadingValue;
        public float MaximumLading
        {
            get { return maxLadingValue; }
            set
            {
                if (value >= 0f)
                    maxLadingValue = value;
            }
        }

        public override double GetKyotoScore()
        {
            return MaximumLading != 0 ? (GemiddeldVerbruik * Pk) / (MaximumLading / 1000.0) : 0.0;
        }

        public override double GeefVervuiling()
        {
            return GetKyotoScore() * 20;
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Maximumlading: {MaximumLading}");
        }
    }
}
