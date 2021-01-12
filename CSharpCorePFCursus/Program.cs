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
            byte? aantalKinderen = null;
            byte aantalKamers;
            aantalKamers = aantalKinderen ?? 0;
            Console.WriteLine($"Er zijn {aantalKamers} kinderkamers nodig");
        }
    }
}