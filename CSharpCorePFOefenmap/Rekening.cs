using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Rekening
    {
        private string rekeningNummerValue;
        private readonly DateTime EersteCreatie = new DateTime(1900, 1, 1);
        private DateTime creatieDatumValue;

        public string RekeningNummer
        {
            get { return rekeningNummerValue; }
            set
            {
                if (IsGeldigRekeningNummer(value))
                    rekeningNummerValue = value;
            }
        }

        public decimal Saldo { get; set; }

        public DateTime CreatieDatum
        {
            get { return creatieDatumValue; }
            set
            {
                if (value >= EersteCreatie)
                    creatieDatumValue = value;
            }
        }

        public Rekening(string rekeningNummer, decimal saldo, DateTime creatieDatum)
        {
            this.RekeningNummer = rekeningNummer;
            this.Saldo = saldo;
            this.CreatieDatum = creatieDatum;
        }

        public void Afbeelden()
        {
            Console.WriteLine($"Rekeningnummer: {RekeningNummer}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Creatiedatum: {CreatieDatum}");
        }
        public void Storten(decimal bedrag)
        {
            Saldo += bedrag;
        }

        private bool IsGeldigRekeningNummer(string rekeningNummer)
        {
            if (string.IsNullOrWhiteSpace(rekeningNummer))
                return false;
            if (rekeningNummer.Length != 16)
                return false;
            if (rekeningNummer.Substring(0, 2) != "BE")
                return false;
            if (!int.TryParse(rekeningNummer.Substring(2, 2), out int derdevierdeteken))
                return false;
            if (!ulong.TryParse(rekeningNummer.Substring(4, 12), out ulong belgischRekeningNummer))
                return false;
            ulong eerste10 = belgischRekeningNummer / 100ul;
            int laatste2 = (int)(belgischRekeningNummer % 100ul);
            return (int)(eerste10 % 97ul) == laatste2;

        }
    }
}
