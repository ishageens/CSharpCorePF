using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Spaarrekening : Rekening
    {
        public Spaarrekening(string nummer, decimal saldo, DateTime creatieDatum, Klant eigenaar) : base(nummer, saldo, creatieDatum, eigenaar)
        {
        }

        private static decimal intrestValue;
        public static decimal Intrest
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
