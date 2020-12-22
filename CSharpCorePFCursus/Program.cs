using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbeider asterix = new Arbeider("Asterix", new DateTime(2019, 1, 1),
            Geslacht.Man, 24.79m, 3);
            Bediende obelix = new Bediende("Obelix", new DateTime(1995, 1, 1),
            Geslacht.Man, 2400.79m);
            Manager idefix = new Manager("Idefix", new DateTime(1996, 1, 1),
            Geslacht.Man, 2400.79m, 7000m);
            Console.WriteLine(asterix.Premie);
            Console.WriteLine(obelix.Premie);
            Console.WriteLine(idefix.Premie);
        }
    }
}