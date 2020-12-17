using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Verwisselaar
    {
        public void Verwissel(ref int getal1, ref int getal2)
        {
            int tussen = getal1;
            getal1 = getal2;
            getal2 = tussen;
        }
    }
}
