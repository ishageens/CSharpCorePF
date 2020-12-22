using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            object ik = new Manager("Asterix", new DateTime(2019, 1, 1),
            Geslacht.Man, 2400.79m, 7000m);
            Console.WriteLine(ik is Manager);
            Console.WriteLine(ik is Bediende);
            Console.WriteLine(ik is Werknemer);
            Console.WriteLine(ik is Arbeider);
            Console.WriteLine(ik is string);
        }
    }
}