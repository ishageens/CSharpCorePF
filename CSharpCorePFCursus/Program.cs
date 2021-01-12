using System;
using System.Collections.Generic;
using System.Linq;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;
namespace CSharpCorePFCursus
{
    class Program
    {
        public static void Main(string[] args)
        {
            var brouwers = new Brouwers().GetBrouwers();
            var opBelgisch = from brouwer in brouwers
                             group brouwer by brouwer.Belgisch;
            foreach (var welNietBelgisch in opBelgisch)
            {
                Console.WriteLine(welNietBelgisch.Key ? "Belgisch" : "Niet-Belgisch");
                foreach (var brouwer in welNietBelgisch)
                    Console.WriteLine(brouwer.Brouwernaam);
            }
        }
    }
}