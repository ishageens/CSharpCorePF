using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tik je leeftijd:");
            int leeftijd = int.Parse(Console.ReadLine());
            Console.Write("Je bent");
            if (leeftijd < 18)
                Console.Write(" niet");
            Console.WriteLine(" toegelaten.");
        }
    }
}
