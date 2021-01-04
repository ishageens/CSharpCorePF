using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig[] voertuigen = new Voertuig[2];
            voertuigen[0] = new Vrachtwagen("Jos", 125000, 250, 1000, "1abc758", 2500);
            voertuigen[1] = new Personenwagen("Jef", 85000, 100, 600, "1def654", 5, 5);
            foreach (Voertuig voertuig in voertuigen)
            {
                voertuig.Afbeelden();
                Console.WriteLine(voertuig.GetKyotoScore());
                Console.WriteLine();

            }
        }
    }
}
