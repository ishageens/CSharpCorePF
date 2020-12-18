using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekening rekening = new Rekening("BE19731021964512", 100, DateTime.Today);
            rekening.Afbeelden();
            rekening.Storten(100m);
            rekening.Afbeelden();

        }
    }
}
