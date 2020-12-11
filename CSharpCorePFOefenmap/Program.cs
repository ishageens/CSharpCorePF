using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je aankoopbedrag?");
            float aankoopBedrag = float.Parse(Console.ReadLine());
            float korting;
            if (aankoopBedrag < 25)
            {
                korting = (aankoopBedrag / 100) * 1;
            }
            else if (aankoopBedrag >= 25 && aankoopBedrag < 50)
            {
                korting = (aankoopBedrag / 100) * 2;
            }
            else if (aankoopBedrag >= 50 && aankoopBedrag < 100)
            {
                korting = (aankoopBedrag / 100) * 3;
            }
            else
            {
                korting = (aankoopBedrag / 100) * 5;
            }
            Console.WriteLine($"Je korting bedraagt {korting} procent");
        }
    }
}
