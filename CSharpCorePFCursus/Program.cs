using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CSharpCorePFCursus
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<Pizza> pizzas;
                using var bestand = File.Open(@"C:\Data\Pizzas.obj",
                FileMode.Open, FileAccess.Read);
                var lezer = new BinaryFormatter();
                pizzas = (List<Pizza>)lezer.Deserialize(bestand);
                foreach (var pizza in pizzas)
                {
                    Console.WriteLine(pizza.Naam);
                    foreach (var onderdeel in pizza.Onderdelen)
                        Console.WriteLine(onderdeel);
                    Console.WriteLine(pizza.Prijs);
                }
            }
            catch (IOException)
            {
                throw new Exception("Fout bij het openen van het bestand!");
            }
            catch (SerializationException)
            {
                Console.WriteLine("Fout bij het serialiseren/deserialiseren");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}