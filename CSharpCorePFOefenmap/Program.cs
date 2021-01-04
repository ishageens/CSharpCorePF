using System;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekening[] rekeningen = new Rekening[2];
            rekeningen[0] = new Spaarrekening("BE19731021964512", 200, DateTime.Today);
            rekeningen[1] = new Zichtrekening("BE19731021964512", 100, DateTime.Today, -750);
            foreach (Rekening eenRekening in rekeningen)
                eenRekening.Afbeelden();

        }
    }
}
