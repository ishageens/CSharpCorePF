using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    public abstract partial class Werknemer : IKost
    {
        public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
        {
        }

        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            this.Naam = naam;
            this.InDienst = inDienst;
            this.Geslacht = geslacht;
        }

        static Werknemer()
        {
            Personeelsfeest = new DateTime(DateTime.Today.Year, 2, 1);
            while (Personeelsfeest.DayOfWeek != DayOfWeek.Friday)
                Personeelsfeest = Personeelsfeest.AddDays(1);
        }
        private string naamValue;
        public string Naam
        {
            get { return naamValue; }
            set
            {
                if (value != string.Empty)
                    naamValue = value;
            }
        }

        public DateTime InDienst { get; set; }
        public Geslacht Geslacht { get; set; }

        private decimal salarisValue;
        public decimal Salaris
        {
            get { return salarisValue; }
            private set
            {
                if (value >= 0m)
                    salarisValue = value;
            }
        }

        public bool VerjaarAncien
        {
            get
            {
                return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day;
            }
        }

        private static DateTime personeelsfeestValue;
        public static DateTime Personeelsfeest
        {
            set
            {
                personeelsfeestValue = value;
            }
            get
            {
                return personeelsfeestValue;
            }
        }

        public DateTime[] Verlofdagen { get; set; }
        public DateTime[] Ziektedagen { get; set; }

        public override string ToString()
        {
            return $"{Naam} {Geslacht}";
        }

        public abstract decimal Premie
        {
            get;
        }
        public Afdeling Afdeling { get; set; }

        public abstract decimal Bedrag
        {
            get;
        }

        public bool Menselijk
        {
            get
            {
                return true;
            }
        }

        public static void UitgebreideWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Uitgebreide werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
                werknemer.Afbeelden();
        }

        public static void KorteWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Korte werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
                Console.WriteLine(werknemer.ToString());
        }
        public virtual void Afbeelden()
        {
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Geslacht: {Geslacht}");
            Console.WriteLine($"In dienst: {InDienst}");
            Console.WriteLine($"Personeelsfeest: {Personeelsfeest}");
            if (Afdeling != null)
                Console.WriteLine(Afdeling);
        }
    }
}
