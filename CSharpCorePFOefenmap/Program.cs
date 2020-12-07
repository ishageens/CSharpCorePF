using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        const float GemLichTempCelcius = 37.0F;
        static void Main(string[] args)
        {
            float GemLichTemptFahrenheit =
                GemLichTempCelcius * 9.0F / 5.0F + 32.0F;
            Console.WriteLine("Gemiddelde lichaamstemperatuur in graden Celcius: " + GemLichTempCelcius);
            Console.WriteLine("Gemiddelde lichaamstemperatuur in graden Fahrenheit: " + GemLichTemptFahrenheit);



        }
    }
}
