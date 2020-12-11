using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef een jaartal");
            int jaar = int.Parse(Console.ReadLine());

            string schrikkel;
            if (jaar % 4 == 0)
                if (jaar % 100 == 0 && jaar % 400 != 0)
                    schrikkel = "geen";
                else schrikkel = "een";
            else
                schrikkel = "geen";
            Console.WriteLine("Het jaar {0} is {1} schrikkeljaar", jaar, schrikkel);
        }
    }
}
