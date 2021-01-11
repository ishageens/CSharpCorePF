using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankbediende deBankbediende = new Bankbediende("Jos", "Vermeulen");
            Klant ik = new Klant("Isha", "Geens");

            Zichtrekening zr = new Zichtrekening("BE19731021964512", 100m, DateTime.Today, ik, -10);
            Console.WriteLine("Zichtrekening: ");
            zr.Afbeelden();
            Console.WriteLine();

            zr.RekeningUittreksel += deBankbediende.ToonRekeningUittreksel;
            zr.SaldoInHetRood += deBankbediende.ToonSaldoInHetRood;

            zr.Storten(50m);
            Console.WriteLine();

            zr.Afhalen(100m);
            Console.WriteLine();

            zr.Afhalen(100m);
            Console.WriteLine();

            Spaarrekening.Intrest = 0.01m;
            Spaarrekening sr = new Spaarrekening("BE40645100000163", 1000m, DateTime.Today, ik);

            sr.RekeningUittreksel += deBankbediende.ToonRekeningUittreksel;
            sr.SaldoInHetRood += deBankbediende.ToonSaldoInHetRood;

            Console.WriteLine("Spaarrekening: ");
            sr.Afbeelden();
            Console.WriteLine();


            sr.Storten(2000m);
            Console.WriteLine();

            sr.Afhalen(1000m);
            Console.WriteLine();

            sr.Afhalen(4000m);

        }
    }
}
