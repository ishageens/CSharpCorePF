using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Spaarrekening : Rekening
    {
        public Spaarrekening(string nummer, decimal saldo, DateTime creatieDatum, decimal intrest) : base(nummer, saldo, creatieDatum)
        {
            Intrest = intrest;
        }

        private decimal intrestValue;
        public decimal Intrest
        {
            get { return intrestValue; }
            set
            {
                if (value >= 0)
                    intrestValue = value;
            }
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Intrest: {Intrest}");
        }
    }
}
