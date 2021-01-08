using System;
using System.Collections.Generic;
using System.Text;

namespace BoekBoekenrek
{
    class Leesboek : Boek
    {
        public override decimal Winst
        {
            get
            {
                return Aankoopprijs * 1.5m;
            }
        }

        private string onderwerpValue;
        public string Onderwerp
        {
            get
            {
                return onderwerpValue;
            }
            set
            {
                if (value != null)
                    onderwerpValue = value;
            }
        }

        public Leesboek(string titel, string auteur, decimal prijs, string onderwerp, Genre genre) : base(titel, auteur, prijs, genre)
        {
            Onderwerp = onderwerp;
        }

        public override string GegevensTonen()
        {
            return
                $"Leesboek \n" +
                $"--------- \n" +
                base.GegevensTonen() +
                $"Onderwerp: {Onderwerp} \n";

        }
    }
}
