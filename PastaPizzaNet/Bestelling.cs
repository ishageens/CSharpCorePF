using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace PastaPizzaNet
{
    [Serializable]
    public class Bestelling : IBedrag
    {
        public Klant Klant { get; set; } = new Klant(0, "Onbekende Klant");

        public BesteldGerecht BesteldGerecht { get; set; }
        public Drank Drank { get; set; }
        public Dessert Dessert { get; set; }

        public int Aantal { get; set; } = 1;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Klant.ToString());
            if (BesteldGerecht != null)
                sb.AppendLine(BesteldGerecht.ToString());
            else
                sb.Append(String.Empty);
            if (Drank != null)
                sb.AppendLine(Drank.ToString());
            else
                sb.Append(String.Empty);
            if (Dessert != null)
                sb.AppendLine(Dessert.ToString());
            else
                sb.Append(String.Empty);
            sb.AppendLine($"Aantal: {Aantal}");
            sb.AppendLine($"Bedrag van deze bestelling: {this.BerekenBedrag()} euro");
            return sb.ToString();
        }

        public decimal BerekenBedrag()
        {
            decimal totaalPrijs = 0;
            if (BesteldGerecht != null)
                totaalPrijs += BesteldGerecht.BerekenBedrag();
            else
                totaalPrijs += 0;
            if (Drank != null)
                totaalPrijs += Drank.BerekenBedrag();
            else
                totaalPrijs += 0;
            if (Dessert != null)
                totaalPrijs += Dessert.BerekenBedrag();
            else
                totaalPrijs += 0;
            totaalPrijs = totaalPrijs * Aantal;
            if (BesteldGerecht != null && Drank != null && Dessert != null)
                totaalPrijs = totaalPrijs * 0.9m;
            return totaalPrijs;
        }

        public static void SchrijfBestellingen(List<Bestelling> bestellingen)
        {
            string locatie = @"C:\Data";
            StringBuilder bestellingenRegel;

            if (!Directory.Exists(locatie))
                Directory.CreateDirectory(locatie);
            try
            {
                using var schrijver = new StreamWriter(locatie + @"\bestellingen.txt");
                foreach (var bestelling in bestellingen)
                {
                    bestellingenRegel = new StringBuilder();
                    if (bestelling.Klant != null)
                        bestellingenRegel.Append(bestelling.Klant.KlantID);
                    else
                        bestellingenRegel.Append("0");
                    bestellingenRegel.Append("#");
                    if (bestelling.BesteldGerecht != null)
                    {
                        bestellingenRegel.Append(bestelling.BesteldGerecht.GevraagdGerecht.Naam + "-");
                        bestellingenRegel.Append(bestelling.BesteldGerecht.Grootte + "-");
                        bestellingenRegel.Append(bestelling.BesteldGerecht.Extras.Count + "-");
                        foreach (var extra in bestelling.BesteldGerecht.Extras)
                            bestellingenRegel.Append(extra + "-");
                    }
                    bestellingenRegel.Append("#");
                    if (bestelling.Drank != null)
                    {
                        if (bestelling.Drank is Frisdrank)
                            bestellingenRegel.Append("F-");
                        else
                            bestellingenRegel.Append("W-");
                        bestellingenRegel.Append(bestelling.Drank.Naam);
                    }
                    bestellingenRegel.Append("#");
                    if (bestelling.Dessert != null)
                    {
                        bestellingenRegel.Append(bestelling.Dessert.Naam);
                    }
                    bestellingenRegel.Append("#");
                    bestellingenRegel.Append(bestelling.Aantal);
                    schrijver.WriteLine(bestellingenRegel);
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

        public static void LeesBestellingen()
        {
            string locatie = @"C:\Data";
            var bestellingen = new List<string>();
            string bestellingenRegel;

            try
            {
                using var lezer = new StreamReader(locatie + @"\bestellingen.txt");
                while ((bestellingenRegel = lezer.ReadLine()) != null)
                {
                    bestellingen.Add(bestellingenRegel);
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
            foreach (var bestelling in bestellingen)
            {
                Console.WriteLine(bestelling);
            }
        }
    }
}
