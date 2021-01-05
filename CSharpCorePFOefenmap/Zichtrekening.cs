using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Zichtrekening : Rekening
    {
        public Zichtrekening(string nummer, decimal saldo, DateTime creatieDatum, Klant eigenaar, decimal maxKrediet) : base(nummer, saldo, creatieDatum, eigenaar)
        {
            MaxKrediet = maxKrediet;
        }

        private decimal maxKredietValue;
        public decimal MaxKrediet
        {
            get { return maxKredietValue; }
            set
            {
                if (value <= 0m)
                    maxKredietValue = value;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Maximum Krediet: {MaxKrediet}");
        }
    }
}
