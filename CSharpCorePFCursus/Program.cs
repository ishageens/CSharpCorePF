using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Omzetter omzetter = new Omzetter();
            Console.Write("Afstand in cm: ");
            if (double.TryParse(Console.ReadLine(), out double cm))
            {
                Console.WriteLine($"{omzetter.CmNaarInch(cm)} inches");
            }
            else
            {
                Console.WriteLine("Geen geldig getal");
            }

            LijnenTrekker lijnenTrekker = new LijnenTrekker();
            lijnenTrekker.TrekLijn3();
            Console.Write("Afstand in inches: ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine($"{omzetter.InchNaarCm(inches)}");
        }
    }
}