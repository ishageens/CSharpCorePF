using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public abstract class Voertuig
    {
        public string Polishouder { get; set; }

        private decimal kostprijsValue;
        public decimal Kostprijs
        {
            get { return kostprijsValue; }
            set
            {
                if (value > 0m)
                    kostprijsValue = value;
            }
        }

        private int pkValue;
        public int Pk
        {
            get { return pkValue; }
            set
            {
                if (value > 0)
                    pkValue = value;
            }
        }
        private float gemiddeldVerbruikValue;
        public float GemiddeldVerbruik
        {
            get { return gemiddeldVerbruikValue; }
            set
            {
                if (value > 0f)
                    gemiddeldVerbruikValue = value;
            }
        }

        public string Nummerplaat { get; set; }




        public Voertuig() : this("onbepaald", 0m, 0, 0f, "onbepaald")
        {
        }

        public Voertuig(string polisHouder, decimal kostprijs, int pk, float gemVerbruik, string nummerPlaat)
        {
            this.Polishouder = polisHouder;
            this.Kostprijs = kostprijs;
            this.Pk = pk;
            this.GemiddeldVerbruik = gemVerbruik;
            this.Nummerplaat = nummerPlaat;
        }

        public abstract double GetKyotoScore();

        public virtual void Afbeelden()
        {
            Console.WriteLine($"Polishouder: {Polishouder}");
            Console.WriteLine($"Kostprijs: {Kostprijs}");
            Console.WriteLine($"Pk: {Pk}");
            Console.WriteLine($"Gemiddeld verbruik: {GemiddeldVerbruik}");
            Console.WriteLine($"Nummerplaat: {Nummerplaat}");
        }
    }
}
