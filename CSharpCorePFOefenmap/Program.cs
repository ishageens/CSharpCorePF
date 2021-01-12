using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            var planten = new List<Plant>
            {
                new Plant { PlantId = 1 , Plantennaam = "Tulp", Kleur = "rood", Prijs = 0.50m , Soort = "bol" },
                new Plant { PlantId = 2 , Plantennaam = "Krokus", Kleur = "wit", Prijs = 0.20m, Soort = "bol" },
                new Plant { PlantId = 3, Plantennaam = "Narcis", Kleur = "geel", Prijs = 0.30m, Soort = "bol" },
                new Plant { PlantId = 4, Plantennaam = "Blauw druifje", Kleur = "blauw", Prijs = 0.20m, Soort = "bol" },
                new Plant { PlantId = 5, Plantennaam = "Azalea", Kleur = "rood", Prijs = 3.00m, Soort = "heester" },
                new Plant { PlantId = 6, Plantennaam = "Forsythia", Kleur = "geel", Prijs = 2.00m, Soort = "heester" },
                new Plant { PlantId = 7, Plantennaam = "Magnolia", Kleur = "wit", Prijs = 4.00m, Soort = "heester" },
                new Plant { PlantId = 8, Plantennaam = "Waterlelie", Kleur = "wit", Prijs = 2.00m, Soort = "water" },
                new Plant { PlantId = 9, Plantennaam = "Lisdodde", Kleur = "geel", Prijs = 3.00m, Soort = "water" },
                new Plant { PlantId = 10, Plantennaam = "Kalmoes", Kleur = "geel", Prijs = 2.50m, Soort = "water" },
                new Plant { PlantId = 11, Plantennaam = "Bieslook", Kleur = "paars", Prijs = 1.50m, Soort = "kruid" },
                new Plant { PlantId = 12, Plantennaam = "Rozemarijn", Kleur = "blauw", Prijs = 1.25m, Soort = "kruid" },
                new Plant { PlantId = 13, Plantennaam = "Munt", Kleur = "wit", Prijs = 1.10m, Soort = "kruid" },
                new Plant { PlantId = 14, Plantennaam = "Dragon", Kleur = "wit", Prijs = 1.30m, Soort = "kruid" },
                new Plant { PlantId = 15, Plantennaam = "Basilicum", Kleur = "wit", Prijs = 1.50m, Soort = "kruid" }
            };

            var opPrijs = from plant in planten
                          where plant.Kleur == "wit"
                          orderby plant.Prijs
                          select plant;
            foreach (var plant in opPrijs)
                Console.WriteLine($"Plantnaam: {plant.Plantennaam}, kleur: {plant.Kleur}, prijs: {plant.Prijs}");
            Console.WriteLine();
            var aantalWitte = from plant in planten
                              where plant.Kleur == "wit"
                              select plant;
            Console.WriteLine(aantalWitte.Count());
            Console.WriteLine();

            var heesters = from plant in planten
                           where plant.Soort == "heester"
                           select plant;
            var gemiddeldePrijsHeesters = heesters.Average(plant => plant.Prijs);
            Console.WriteLine($"Gemiddelde prijs heesters: {gemiddeldePrijsHeesters}");
            Console.WriteLine();

            var kruiden = from plant in planten
                          where plant.Soort == "kruid"
                          select plant;
            var gemiddeldePrijsKruiden = kruiden.Average(plant => plant.Prijs);
            var maximumPrijsKruiden = kruiden.Max(Plant => Plant.Prijs);
            Console.WriteLine($"Gemiddelde prijs kruiden: {gemiddeldePrijsKruiden}, maximumprijs kruiden: {maximumPrijsKruiden}");
            Console.WriteLine();

            var startMetB = from plant in planten
                            where plant.Plantennaam.StartsWith("B")
                            select plant;
            foreach (var plant in startMetB)
                Console.WriteLine(plant.Plantennaam);
            Console.WriteLine();

            var kleuren = (from plant in planten
                           select plant.Kleur).Distinct();
            foreach (var kleur in kleuren)
                Console.WriteLine(kleur);
            Console.WriteLine();

            var opKleur = from plant in planten
                          group plant by plant.Kleur
                          into kleurgroep
                          select kleurgroep;
            foreach (var groep in opKleur)
            {
                Console.WriteLine($"Kleur {groep.Key}");
                foreach (var plant in groep)
                {
                    Console.WriteLine($"\t{plant.Plantennaam}");
                }
            }

            var opSoort = from plant in planten
                          group plant by plant.Soort
                          into soorten
                          select soorten;
            foreach (var soort in opSoort)
            {
                Console.WriteLine(soort.Key);
                var maximumPrijsPerSoort = soort.Max(plant => plant.Prijs);
                Console.WriteLine(maximumPrijsPerSoort);
            }
            Console.WriteLine();

            var alfabetisch = from plant in planten
                              group plant by plant.Soort
                              into soorten
                              select soorten;
            foreach (var soort in alfabetisch)
            {
                Console.WriteLine($"Soortnaam: {soort.Key}");
                var totaal = soort.Count();
                Console.WriteLine($"Totaal aantal planten: {totaal}");
                foreach (var plant in soort)
                {
                    Console.WriteLine(plant.Plantennaam);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var perSoortKleur = from plant in planten
                                group plant by plant.Soort
                                into soortgroep
                                select new
                                {
                                    Soort = soortgroep.Key,
                                    Groepkleur = from plant in soortgroep
                                                 group plant by plant.Kleur
                                                 into kleurgroep
                                                 select new
                                                 {
                                                     Kleur = kleurgroep.Key,
                                                     Planten = kleurgroep
                                                 }
                                };
            foreach (var soort in perSoortKleur)
            {
                Console.WriteLine($"Soort: {soort.Soort}");
                foreach (var kleur in soort.Groepkleur)
                {
                    Console.WriteLine($" Kleur: {kleur.Kleur}");
                    foreach (var plant in kleur.Planten)
                        Console.WriteLine($"    {plant.Plantennaam}");
                }
            }
        }
    }
}
