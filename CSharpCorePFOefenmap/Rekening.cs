using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public abstract class Rekening
    {
        private readonly DateTime EersteCreatie = new DateTime(1900, 1, 1); private string nummerValue;
        private DateTime creatieDatumValue;
        public string Nummer { get { return nummerValue; } set { if (IsGeldigRekeningNummer(value)) { nummerValue = value; } } }
        public decimal Saldo { get; set; }
        public DateTime CreatieDatum
        {
            get
            {
                return creatieDatumValue;
            }
            set
            {
                if (value >= EersteCreatie)
                    creatieDatumValue = value;
            }
        }
        public Rekening(string nummer, decimal saldo, DateTime creatieDatum, Klant eigenaar)
        {
            Nummer = nummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
            Eigenaar = eigenaar;
        }

        public Klant Eigenaar { get; set; }
        public virtual void Afbeelden()
        {
            Console.WriteLine($"Rekeningnummer: {Nummer}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Creatiedatum: {CreatieDatum:dd-MM-yyyy}");
            if (Eigenaar != null)
                Eigenaar.Afbeelden();
        }
        public void Storten(decimal bedrag)
        {
            Saldo += bedrag;
        }
        private bool IsGeldigRekeningNummer(string rekeningNummer)
        {
            if (string.IsNullOrWhiteSpace(rekeningNummer)) return false;
            if (rekeningNummer.Length != 16) return false;
            if (rekeningNummer.Substring(0, 2) != "BE") return false;
            if (!int.TryParse(rekeningNummer.Substring(2, 2), out int derdevierdeteken))
                return false;
            if (!ulong.TryParse(rekeningNummer.Substring(4, 12),
            out ulong belgischRekeningNummer))
                return false; ulong eerste10 = belgischRekeningNummer / 100ul; int laatste2 = (int)(belgischRekeningNummer % 100ul); return (int)(eerste10 % 97ul) == laatste2;
        }
    }
}
