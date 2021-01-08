using System;
using Firma;
using Firma.Personeel;

namespace CSharpCorePFCursus
{
    class Program
    {
        delegate void WerknemersLijst(Werknemer[] werknemers);
        public static void Main(string[] args)
        {
            Werknemer[] wij = new Werknemer[3];
            wij[0] = new Arbeider("Asterix", new DateTime(2019, 1, 1), Geslacht.Man, 24.79m, 3);
            wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
            wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);

            WerknemersLijst lijst;
            lijst = Werknemer.UitgebreideWerknemersLijst;
            lijst(wij);
            Console.WriteLine();
            lijst = Werknemer.KorteWerknemersLijst;
            lijst(wij);
        }
    }
}