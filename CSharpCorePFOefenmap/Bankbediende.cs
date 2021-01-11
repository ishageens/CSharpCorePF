using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public class Bankbediende
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }

        public Bankbediende(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
        }

        public override string ToString()
        {
            return $"Bankbediende {Voornaam} {Naam}";
        }
        public void ToonRekeningUittreksel(Rekening rekening)
        {
            Console.WriteLine($"Datum: {DateTime.Today:dd-MM-yyyy}");
            Console.WriteLine($"Rekeninguittreksel van " + $"rekening {rekening.Nummer}");
            Console.WriteLine($"Vorig saldo: {rekening.VorigSaldo} euro");

            if (rekening.Saldo > rekening.VorigSaldo)
            {
                Console.WriteLine($"Storting van {rekening.Saldo - rekening.VorigSaldo} euro.");
            }
            else
            {
                Console.WriteLine($"Afhaling van {rekening.VorigSaldo - rekening.Saldo} euro.");
            }
            Console.WriteLine($"Nieuw saldo: {rekening.Saldo} euro.");
        }

        public void ToonSaldoInHetRood(Rekening rekening)
        {
            Console.WriteLine("Afhaling niet mogelijk, saldo ontoereikend!");
            Console.WriteLine($"Maximum af te halen bedrag: {rekening.Saldo} euro");

        }
    }
}
