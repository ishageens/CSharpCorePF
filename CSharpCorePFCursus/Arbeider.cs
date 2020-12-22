using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Arbeider : Werknemer
    {
        public Arbeider(string naam, DateTime inDienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel) : base(naam, inDienst, geslacht)
        {
            Uurloon = uurloon;
            Ploegenstelsel = ploegenstelsel;
        }

        private decimal uurloonValue;
        public decimal Uurloon
        {
            get { return uurloonValue; }
            set
            {
                if (value >= 0m)
                    uurloonValue = value;
            }
        }

        private byte ploegenstelselValue;
        public byte Ploegenstelsel
        {
            get { return ploegenstelselValue; }
            set
            {
                if (value >= 1 && value <= 3)
                    ploegenstelselValue = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Uurloon} euro/uur";
        }

        public override decimal Premie
        {
            get
            {
                return Uurloon * 150m;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Uurloon: {Uurloon}");
            Console.WriteLine($"Ploegenstelsel: {Ploegenstelsel}");
        }
    }
}
