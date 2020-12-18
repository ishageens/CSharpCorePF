using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Werknemer ik = new Werknemer("Asterix", new DateTime(2019, 1, 1), Geslacht.Man);
            ik.Afbeelden();

        }
    }
}