using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Afdeling afdeling1 = new Afdeling("Strijd", 0);
            Afdeling afdeling2 = new Afdeling("Feest", 1);

            Werknemer[] wij = new Werknemer[3];
            wij[0] = new Arbeider("Asterix", new DateTime(2019, 1, 1), Geslacht.Man, 24.79m, 3);
            wij[0].Afdeling = afdeling1;
            wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
            wij[1].Afdeling = afdeling1;
            wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
            wij[2].Afdeling = afdeling2;
            foreach (Werknemer eenWerknemer in wij)
                eenWerknemer.Afbeelden();
        }
    }
}