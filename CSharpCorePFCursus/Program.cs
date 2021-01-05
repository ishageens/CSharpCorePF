using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            IKost[] kosten = new IKost[4];
            kosten[0] = new Arbeider("Asterix", new DateTime(2019, 1, 1),
            Geslacht.Man, 24.79m, 3);
            kosten[1] = new Bediende("Obelix", new DateTime(2019, 2, 1),
            Geslacht.Man, 2400.79m);
            kosten[2] = new Manager("Idefix", new DateTime(2019, 3, 1),
            Geslacht.Man, 2400.79m, 7000m);
            kosten[3] = new Fotokopiemachine("123", 500, 0.025m);
            decimal totaleKost = 0m;
            foreach (IKost kost in kosten)
            {
                Console.WriteLine(kost.Menselijk);
                Console.WriteLine(kost.Bedrag);
                totaleKost += kost.Bedrag;
            }
            Console.WriteLine(totaleKost);
        }
    }
}