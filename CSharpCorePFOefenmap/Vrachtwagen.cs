﻿using System;
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

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Maximumlading: {MaximumLading}");
        }
    }
}