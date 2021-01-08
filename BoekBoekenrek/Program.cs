using System;

namespace BoekBoekenrek
{
    class Program
    {
        static void Main(string[] args)
        {
            IVoorwerpen[] voorwerpen = new IVoorwerpen[3];

            voorwerpen[0] = new Leesboek("Harry Potter", "J.K. Rowling", 20m, "toveren", new Genre("fictie", new Doelgroep(15)));
            voorwerpen[1] = new Woordenboek("Vandale", "Kramers", 100m, "NL-E", new Genre("vreemd", new Doelgroep(20)));
            voorwerpen[2] = new Boekenrek(3f, 2.5f, 200m);

            foreach (IVoorwerpen voorwerp in voorwerpen)
                Console.WriteLine(voorwerp.GegevensTonen());

            for (int i = 0; i < 20; i++)
                Console.Write("-");
            Console.WriteLine();
        }
    }
}
