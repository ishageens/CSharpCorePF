using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Vrachtwagen vw1 = new Vrachtwagen("Jos", 125000, 250, 1000, "1abc758", 2500);
            vw1.Afbeelden();

            Vrachtwagen vw2 = new Vrachtwagen();
            vw2.Afbeelden();

            Personenwagen pw1 = new Personenwagen("Jef", 85000, 100, 600, "1def654", 5, 5);
            pw1.Afbeelden();

            Personenwagen pw2 = new Personenwagen();
            pw2.Afbeelden();

        }
    }
}
