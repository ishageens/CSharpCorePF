using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Materiaal
{
    public delegate void Onderhoudsbeurt(Fotokopiemachine machine);
    public class Fotokopiemachine : IKost
    {
        public event Onderhoudsbeurt OnderhoudNodig;
        private const int AantalBlzTussen2OnderhoudsBeurten = 10; public void Fotokopieer(int aantalBlz)
        {
            for (int blz = 1; blz <= aantalBlz; blz++)
            {
                Console.WriteLine($"FotokopieMachine {SerieNr} kopieert " +
                $"blz. {blz} van {aantalBlz}");
                if (++AantalGekopieerdeBlz % AantalBlzTussen2OnderhoudsBeurten == 0)
                    if (OnderhoudNodig != null)
                        OnderhoudNodig(this);
            }
        }

        public class KostPerBlzException : Exception
        {
            public decimal VerkeerdeKost { get; set; }

            public KostPerBlzException(string message, decimal verkeerdeKost) : base(message)
            {
                VerkeerdeKost = verkeerdeKost;
            }
        }

        public class AantalGekopieerdeBlzException : Exception
        {
            public int VerkeerdAantalBlz { get; set; }

            public AantalGekopieerdeBlzException(string message, int verkeerdAantalBlz) : base(message)
            {
                VerkeerdAantalBlz = verkeerdAantalBlz;
            }
        }
        private int aantalGekopieerdeBlzValue;
        private decimal kostPerBlzValue;
        public string SerieNr { get; set; }
        public int AantalGekopieerdeBlz
        {
            get
            {
                return aantalGekopieerdeBlzValue;
            }
            set
            {
                if (value < 0)
                    throw new AantalGekopieerdeBlzException("Aantal gekopieerde blz. < 0!", value);
                aantalGekopieerdeBlzValue = value;
            }
        }
        public decimal KostPerBlz
        {
            get
            {
                return kostPerBlzValue;
            }
            set
            {
                if (value <= 0)
                    throw new KostPerBlzException("Kost per blz. <=0!", value);
                kostPerBlzValue = value;
            }
        }
        public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz,
        decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalGekopieerdeBlz = aantalGekopieerdeBlz;
            KostPerBlz = kostPerBlz;
        }
        public bool Menselijk
        {
            get
            {
                return false;
            }
        }
        public decimal Bedrag
        {
            get
            {
                return AantalGekopieerdeBlz * KostPerBlz;
            }
        }
    }
}
