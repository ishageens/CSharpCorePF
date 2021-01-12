using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpCorePFCursus
{
    [Serializable]
    class Pizza
    {
        public string Naam { get; set; }
        public List<String> Onderdelen { get; set; }
        public decimal Prijs { get; set; }

        public override string ToString() => $"{this.Naam}: {this.Prijs} EUR";
    }
}
