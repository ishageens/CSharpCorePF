using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Zichtrekening : Rekening
    {
        public Zichtrekening(string nummer, decimal saldo, DateTime creatieDatum, decimal maxKrediet) : base(nummer, saldo, creatieDatum)
        {
            MaxKrediet = maxKrediet;
        }

        private decimal maxKredietValue;
        public decimal MaxKrediet
        {
            get { return maxKredietValue; }
            set
            {
                if (value < 0)
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
