using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace PastaPizzaNet
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Bestellingen aanmaken
            List<Gerecht> gerechtenLijst = new Gerechten().GerechtenLijst();
            List<Bestelling> alleBestellingen = new List<Bestelling>();
            List<Klant> klantenLijst = new List<Klant>();

            Klant klant1 = new Klant(1, "Jan Janssen");
            Klant klant2 = new Klant(2, "Piet Peeters");
            klantenLijst.Add(klant1);
            klantenLijst.Add(klant2);

            BesteldGerecht besteldGerecht1 = new BesteldGerecht(gerechtenLijst[0], Grootte.Groot, new List<Extras> { Extras.Kaas, Extras.Look });
            Frisdrank drinken1 = new Frisdrank(DrankenLijst.Water);
            Dessert dessert1 = new Dessert(DessertenLijst.Ijs);
            Bestelling bestelling1 = new Bestelling { Klant = klant1, BesteldGerecht = besteldGerecht1, Drank = drinken1, Dessert = dessert1, Aantal = 2 };
            alleBestellingen.Add(bestelling1);

            BesteldGerecht besteldGerecht2 = new BesteldGerecht(gerechtenLijst[0], Grootte.Klein, new List<Extras> { });
            Drank drinken2 = new Frisdrank(DrankenLijst.Water);
            Dessert dessert2 = new Dessert(DessertenLijst.Tiramisu);
            Bestelling bestelling2 = new Bestelling { Klant = klant2, BesteldGerecht = besteldGerecht2, Drank = drinken2, Dessert = dessert2 };
            alleBestellingen.Add(bestelling2);

            BesteldGerecht besteldGerecht3 = new BesteldGerecht(gerechtenLijst[1], Grootte.Groot, new List<Extras> { });
            Drank drinken3 = new WarmeDrank(DrankenLijst.Thee);
            Dessert dessert3 = new Dessert(DessertenLijst.Ijs);
            Bestelling bestelling3 = new Bestelling { Klant = klant2, BesteldGerecht = besteldGerecht3, Drank = drinken3, Dessert = dessert3 };
            alleBestellingen.Add(bestelling3);

            BesteldGerecht besteldGerecht4 = new BesteldGerecht(gerechtenLijst[7], Grootte.Klein, new List<Extras> { Extras.Look });
            Bestelling bestelling4 = new Bestelling { BesteldGerecht = besteldGerecht4 };
            alleBestellingen.Add(bestelling4);

            BesteldGerecht besteldGerecht5 = new BesteldGerecht(gerechtenLijst[5], Grootte.Klein, new List<Extras> { });
            Drank drinken5 = new Frisdrank(DrankenLijst.Cocacola);
            Bestelling bestelling5 = new Bestelling { Klant = klant1, BesteldGerecht = besteldGerecht5, Drank = drinken5 };
            alleBestellingen.Add(bestelling5);

            BesteldGerecht besteldGerecht6 = new BesteldGerecht(gerechtenLijst[4], Grootte.Groot, new List<Extras> { Extras.Kaas });
            Drank drinken6 = new Frisdrank(DrankenLijst.Cocacola);
            Dessert dessert6 = new Dessert(DessertenLijst.Cake);
            Bestelling bestelling6 = new Bestelling { Klant = klant2, BesteldGerecht = besteldGerecht6, Drank = drinken6, Dessert = dessert6 };
            alleBestellingen.Add(bestelling6);

            Drank drinken7 = new WarmeDrank(DrankenLijst.Koffie);
            Bestelling bestelling7 = new Bestelling { Klant = klant2, Drank = drinken7, Aantal = 3 };
            alleBestellingen.Add(bestelling7);

            Dessert dessert8 = new Dessert(DessertenLijst.Tiramisu);
            Bestelling bestelling8 = new Bestelling { Klant = klant1, Dessert = dessert8 };
            alleBestellingen.Add(bestelling8);


            // UITVOERING
            ////Lijst tonen
            //int bestellingsnr = 0;
            //foreach (var bestelling in alleBestellingen)
            //{
            //    bestellingsnr++;
            //    Console.WriteLine($"Bestelling {bestellingsnr}:");
            //    Console.WriteLine(bestelling);
            //    for (int i = 0; i < 50; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            ////Bestellingen van Jan Janssen
            //var janJanssen = from bestelling in alleBestellingen
            //                 where bestelling.Klant.KlantID == 1
            //                 select bestelling;
            //decimal totaaljanJanssen = 0;
            //foreach (var bestelling in janJanssen)
            //{
            //    Console.WriteLine(bestelling);
            //    totaaljanJanssen += bestelling.BerekenBedrag();
            //}
            //Console.WriteLine($"Het totaalbedrag van alle bestellingen van klant {klant1.Naam} is: {totaaljanJanssen} euro");

            ////Bestellingen gegroepeerd per klant
            //var perKlant = from bestelling in alleBestellingen
            //               group bestelling by bestelling.Klant;

            //foreach (var klant in perKlant)
            //{
            //    if (klant.Key.Naam != "Onbekende Klant")
            //        Console.WriteLine($"Bestellingen van klant {klant.Key.Naam}:");
            //    else
            //        Console.WriteLine("Onbekende klanten:");
            //    Console.WriteLine();
            //    decimal totaalPerKlant = 0;
            //    foreach (var bestelling in klant)
            //    {
            //        Console.WriteLine(bestelling);
            //        totaalPerKlant += bestelling.BerekenBedrag();
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine($"Het totaalbedrag van alle bestellingen van klant {klant.Key.Naam} is: {totaalPerKlant} euro");
            //    Console.WriteLine();
            //    for (int i = 0; i < 50; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}


            Gerechten.SchrijfGerechten(gerechtenLijst);
            Gerechten.LeesGerechten();

            Klant.SchrijfKlanten(klantenLijst);
            Klant.LeesKlanten();

            Bestelling.SchrijfBestellingen(alleBestellingen);
            Bestelling.LeesBestellingen();






        }
    }
}
