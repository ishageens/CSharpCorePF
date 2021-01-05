using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public class Stookketel : IVervuiler
    {
        public float CONorm { get; set; }

        public Stookketel(float coNorm)
        {
            CONorm = coNorm;
        }
        public double GeefVervuiling()
        {
            return CONorm * 100;
        }
    }
}
