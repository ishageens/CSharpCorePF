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
            Fotokopiemachine machine1 = new Fotokopiemachine("123", 0, 2.0m);
            Fotokopiemachine machine2 = new Fotokopiemachine("456", 0, 2.5m);
            Bediende eenBediende = new Bediende("Asterix", DateTime.Today, Geslacht.Man, 2400.79m);
            Manager eenManager = new Manager("Idefix", DateTime.Today, Geslacht.Man, 4800.4m, 2000m);
            machine1.OnderhoudNodig += eenBediende.DoeOnderhoud;
            machine1.OnderhoudNodig += eenManager.OnderhoudNoteren;
            machine2.OnderhoudNodig += eenBediende.DoeOnderhoud;
            machine2.OnderhoudNodig += eenManager.OnderhoudNoteren;
            machine1.Fotokopieer(49);
            machine2.Fotokopieer(14);
        }
    }
}