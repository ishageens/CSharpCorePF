using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    public class Bediende : Werknemer
    {
        public void DoeOnderhoud(Firma.Materiaal.Fotokopiemachine machine)
        {
            Console.WriteLine($"{Naam} onderhoudt machine {machine.SerieNr}");
        }
        public Bediende(string naam, DateTime indienst, Geslacht geslacht, decimal wedde) : base(naam, indienst, geslacht)
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

        public override decimal Premie
        {
            get
            {
                return Wedde * 2m;
            }
        }

        public override decimal Bedrag
        {
            get
            {
                return Wedde * 12m;
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden(); Console.WriteLine($"Wedde: {Wedde}");
        }
    }
}
