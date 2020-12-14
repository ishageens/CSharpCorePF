using System;

namespace CSharpCorePFCursus
{
    public enum Seizoen
    {
        Lente = 1, Zomer, Herfst, Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            Seizoen plukseizoen = Seizoen.Herfst;
            Console.WriteLine(plukseizoen);
            Console.WriteLine((int)plukseizoen);


        }
    }
}
