using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Bediende : Werknemer
    {
        public Bediende(string naam, DateTime indienst,
        Geslacht geslacht, decimal wedde)
        : base(naam, indienst, geslacht)
        {
            Wedde = wedde;
        }
        private decimal weddeValue;
        public decimal Wedde
        {
            get
            {
                return weddeValue;
            }
            set
            {
                if (value >= 0m)
                    weddeValue = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Wedde} euro/maand";
        }
        public override void Afbeelden()
        {
            base.Afbeelden(); Console.WriteLine($"Wedde: {Wedde}");
        }
    }
}
