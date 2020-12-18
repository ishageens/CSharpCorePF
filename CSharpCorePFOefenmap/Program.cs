using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig v1 = new Voertuig();
            Voertuig v2 = new Voertuig("Jan", 10000m, 75, 6.0f, "1-ABC-123");
            Voertuig v3 = new Voertuig("Piet", 15000m, 80, -7.5f, "1-DEF-456");
            v1.Afbeelden(); Console.WriteLine();
            v2.Afbeelden(); Console.WriteLine();
            v3.Afbeelden();

        }
    }
}
