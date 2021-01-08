using System;
using System.Collections.Generic;
using System.Text;

namespace BoekBoekenrek
{
    class Woordenboek : Boek
    {
        public override decimal Winst
        {
            get
            {
                return Aankoopprijs * 1.75m;
            }
        }

        private string taalValue;
        public string Taal
        {
            get
            {
                return taalValue;
            }
            set
            {
                if (value != null)
                    taalValue = value;
            }
        }
        public Woordenboek(string titel, string auteur, decimal prijs, string taal, Genre genre) : base(titel, auteur, prijs, genre)
        {
            Taal = taal;
        }
        public override string GegevensTonen()
        {
            return $"Woordenboek \n" +
                $"--------- \n" +
                base.GegevensTonen() +
                $"Taal: {Taal} \n";

        }
    }
}
