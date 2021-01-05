using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbeider ik = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 24.79m, 3);
            ik.Regime = new Werknemer.WerkRegime(Werknemer.WerkRegime.RegimeType.Voltijds);
            Console.WriteLine(ik.Regime);
            Console.WriteLine(ik.Regime.AantalVakantieDagen);
        }
    }
}