using System;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;
namespace CSharpCorePFCursus
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Provincie: ");
            string provincie = Console.ReadLine();
            try
            {
                ProvincieInfo info = new ProvincieInfo();
                Console.WriteLine(info.ProvincieGrootte(provincie));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}