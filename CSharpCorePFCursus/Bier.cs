using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    class Bier
    {
        public int BierNr { get; set; }
        public string Biernaam { get; set; }
        public float Alcohol { get; set; }
        public Brouwer Brouwer { get; set; }

        public override string ToString()
        {
            return $"{Biernaam}: {Alcohol}% alcohol";
        }
    }
}
