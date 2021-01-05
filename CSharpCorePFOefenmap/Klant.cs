using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public class Klant
    {
        public Klant(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public void Afbeelden()
        {
            Console.WriteLine($"Voornaam: {Voornaam}");
            Console.WriteLine($"Familienaam: {Familienaam}");
        }
    }
}
