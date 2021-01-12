using System;
using System.Collections.Generic;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;
namespace CSharpCorePFCursus
{
    class Program
    {
        delegate int FunctieMetTweeParameters(int getal1, int getal2);
        delegate int FunctieMetEenParameter(int getal);
        delegate int FunctieZonderParameters();
        public static void Main(string[] args)
        {
            FunctieMetTweeParameters som = (getal1, getal2) => getal1 + getal2;
            Console.WriteLine(som(3, 7));
            Console.WriteLine(som(10, 6));

            FunctieMetEenParameter kwadraat = getal => getal * getal;
            Console.WriteLine(kwadraat(5));

            FunctieZonderParameters willekeurigGetal = () => new Random().Next(10);
            Console.WriteLine(willekeurigGetal());
        }
    }
}