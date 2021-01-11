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
            try
            {
                Fotokopiemachine machine = new Fotokopiemachine("123", -100, -5.4m);
                Console.WriteLine("Machine goed ingevuld");
            }
            catch (Fotokopiemachine.KostPerBlzException ex)
            {
                Console.WriteLine($"Fout: {ex.Message}: {ex.VerkeerdeKost}");
            }
            catch (Fotokopiemachine.AantalGekopieerdeBlzException ex)
            {
                Console.WriteLine($"Fout: {ex.Message}: {ex.VerkeerdAantalBlz}");
            }
            Console.WriteLine("Einde programma");
        }
    }
}