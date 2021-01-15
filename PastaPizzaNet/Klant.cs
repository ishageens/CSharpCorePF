using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace PastaPizzaNet
{
    public class Klant
    {
        public int KlantID { get; set; }
        public string Naam { get; set; }

        public Klant(int klantId, string naam)
        {
            KlantID = klantId;
            Naam = naam;
        }

        public override string ToString() => $"Klant: {Naam}";

        public static void SchrijfKlanten(List<Klant> klanten)
        {
            string locatie = @"C:\Data";
            StringBuilder klantenRegel;

            if (!Directory.Exists(locatie))
                Directory.CreateDirectory(locatie);
            try
            {
                using var schrijver = new StreamWriter(locatie + @"\klanten.txt");
                foreach (var klant in klanten)
                {
                    klantenRegel = new StringBuilder();
                    klantenRegel.Append(klant.KlantID);
                    klantenRegel.Append("#");
                    klantenRegel.Append(klant.Naam);
                    schrijver.WriteLine(klantenRegel);
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

        public static void LeesKlanten()
        {
            string locatie = @"C:\Data";
            var klanten = new List<string>();
            string klantenRegel;

            try
            {
                using var lezer = new StreamReader(locatie + @"\klanten.txt");
                while ((klantenRegel = lezer.ReadLine()) != null)
                {
                    klanten.Add(klantenRegel);
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
            foreach (var klant in klanten)
            {
                Console.WriteLine(klant);
            }
        }
    }
}
