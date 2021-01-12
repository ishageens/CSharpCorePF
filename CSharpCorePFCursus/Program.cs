using System;
using System.Collections.Generic;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;
namespace CSharpCorePFCursus
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Werknemer> werknemers = new List<Werknemer>
            { new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 25m, 1),
                new Bediende("Obelix", DateTime.Today, Geslacht.Man, 1200m)
            };
            Console.WriteLine($"Aantal werknemers: {werknemers.Count}");

            werknemers = null; //NullReferenceException 
            //Console.WriteLine($"Aantal werknemers: {werknemers.Count}");
            Console.WriteLine($"Aantal werknemers: {werknemers?.Count ?? 0}");
        }
    }
}