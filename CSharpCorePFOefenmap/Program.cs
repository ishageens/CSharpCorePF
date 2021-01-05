using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Vrachtwagen vw = new Vrachtwagen("Jos", 125000, 250, 1000, "1abc758", 2500);
            Personenwagen pw = new Personenwagen("Jef", 85000, 100, 600, "1def654", 5, 5);

            Console.WriteLine("Private gegevens:");
            IPrivaat[] privategegevens = new IPrivaat[2];
            privategegevens[0] = vw;
            privategegevens[1] = pw;

            foreach (IPrivaat voertuig in privategegevens)
            {
                Console.WriteLine(voertuig.GeefPrivateData());
            }

            Console.WriteLine("Milieugegevens:");
            IMilieu[] milieugegevens = new IMilieu[2];
            milieugegevens[0] = vw;
            milieugegevens[1] = pw;

            foreach (IMilieu voertuig in milieugegevens)
            {
                Console.WriteLine(voertuig.GeefMilieuData());
            }
        }
    }
}
