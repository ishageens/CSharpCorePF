using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Spaarrekening spaarrekening = new Spaarrekening("BE19731021964512", 0, DateTime.Today, 1);
            spaarrekening.Storten(1000);
            spaarrekening.Afbeelden();

            Zichtrekening zichtrekening = new Zichtrekening("BE19731021964512", 0, DateTime.Today, -750);
            zichtrekening.Storten(125);
            zichtrekening.Afbeelden();

        }
    }
}
