using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public class Kasbon : ISpaarmiddel
    {
        private readonly DateTime eersteAankoopDatum = new DateTime(1900, 1, 1);
        private DateTime aankoopDatumValue;
        private decimal bedragValue;
        private int looptijdValue;
        private decimal intrestValue;
        public DateTime AankoopDatum
        {
            get
            {
                return aankoopDatumValue;
            }
            set
            {
                if (value < eersteAankoopDatum)
                    throw new Exception("Aankoopdatum mag niet voor 01-01-1900 zijn.");
                aankoopDatumValue = value;
            }
        }

        public decimal Bedrag
        {
            get
            {
                return bedragValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Bedrag mag niet negatief zijn.");
                bedragValue = value;
            }
        }
        public int Looptijd
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Looptijd mag niet negatief zijn.");
                looptijdValue = value;
            }
        }
        public decimal Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Intrest mag niet negatief zijn.");
                intrestValue = value;
            }
        }

        public Klant Eigenaar { get; set; }

        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, decimal intrest, Klant eigenaar)
        {
            AankoopDatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Eigenaar = eigenaar;
        }

        public void Afbeelden()
        {
            Console.WriteLine($"Aankoopdatum: {AankoopDatum}");
            Console.WriteLine($"Bedrag: {Bedrag}");
            Console.WriteLine($"Looptijd: {Looptijd}");
            Console.WriteLine($"Intrest: {Intrest}");
            if (Eigenaar != null)
                Eigenaar.Afbeelden();
        }
    }
}
