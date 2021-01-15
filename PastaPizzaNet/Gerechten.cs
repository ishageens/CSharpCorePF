using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PastaPizzaNet
{
    [Serializable]
    public class Gerechten
    {
        public List<Gerecht> GerechtenLijst()
        {
            Pizza pizzaMargherita = new Pizza("Pizza Margherita", 8m, new List<string> { "tomatensaus", "mozzarella" });
            Pizza pizzaNapoli = new Pizza("Pizza Napoli", 10m, new List<string> { "tomatensaus", "mozzarella", "ansjovis", "kappers", "olijven" });
            Pizza pizzaLardiera = new Pizza("Pizza Lardiera", 9.5m, new List<string> { "tomatensaus", "mozzarella", "spek" });
            Pizza pizzaVegetariana = new Pizza("Pizza Vegetariana", 9.5m, new List<string> { "tomatensaus", "mozzarella", "groenten" });
            Pasta spaghettiBolognese = new Pasta("Spaghetti Bolognese", 12m, "met gehaktsaus");
            Pasta spaghettiCarbonara = new Pasta("Spaghetti Carbonara", 13m, "spek, roomsaus en parmezaanse kaas");
            Pasta penneArrabiata = new Pasta("Penne Arrabiata", 14m, "met pittige tomatensaus");
            Pasta lasagne = new Pasta("Lasagne", 15m, string.Empty);
            return new List<Gerecht> { pizzaMargherita, pizzaNapoli, pizzaLardiera, pizzaVegetariana, spaghettiBolognese, spaghettiCarbonara, penneArrabiata, lasagne };
        }

        public static void SchrijfGerechten(List<Gerecht> gerechtenlijst)
        {
            string locatie = @"C:\Data";
            StringBuilder gerechtenRegel;

            if (!Directory.Exists(locatie))
                Directory.CreateDirectory(locatie);
            try
            {
                using var schrijver = new StreamWriter(locatie + @"\gerechten.txt");
                var pizzaLijst = gerechtenlijst.GetRange(0, 4);
                foreach (Pizza pizza in pizzaLijst)
                {
                    gerechtenRegel = new StringBuilder();
                    gerechtenRegel.Append("pizza");
                    gerechtenRegel.Append("#");
                    gerechtenRegel.Append(pizza.Naam);
                    gerechtenRegel.Append("#");
                    gerechtenRegel.Append(pizza.StandaardPrijs);
                    gerechtenRegel.Append("#");
                    foreach (var onderdeel in pizza.Onderdelen)
                    {
                        gerechtenRegel.Append(onderdeel);
                        gerechtenRegel.Append("#");
                    }
                    schrijver.WriteLine(gerechtenRegel);
                }
                var pastaLijst = gerechtenlijst.GetRange(4, 4);
                foreach (Pasta pasta in pastaLijst)
                {
                    gerechtenRegel = new StringBuilder();
                    gerechtenRegel.Append("pasta");
                    gerechtenRegel.Append("#");
                    gerechtenRegel.Append(pasta.Naam);
                    gerechtenRegel.Append("#");
                    gerechtenRegel.Append(pasta.StandaardPrijs);
                    gerechtenRegel.Append("#");
                    gerechtenRegel.Append(pasta.Omschrijving);
                    gerechtenRegel.Append("#");
                    schrijver.WriteLine(gerechtenRegel);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Fout bij openen van bestand");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void LeesGerechten()
        {
            string locatie = @"C:\Data";
            var gerechten = new List<string>();
            string gerechtenRegel;

            try
            {
                using var lezer = new StreamReader(locatie + @"\gerechten.txt");
                while ((gerechtenRegel = lezer.ReadLine()) != null)
                {
                    gerechten.Add(gerechtenRegel);

                }
            }
            catch (IOException)
            {
                Console.WriteLine("Fout bij openen van bestand");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (var gerecht in gerechten)
            {
                Console.WriteLine(gerecht);
            }
        }

    }
}