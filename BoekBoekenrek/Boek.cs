using System;
using System.Collections.Generic;
using System.Text;

namespace BoekBoekenrek
{
    public abstract class Boek : IVoorwerpen
    {
        public const string Eigenaar = "VDAB";
        private string titelValue;
        private string auteurValue;
        private decimal aankoopprijsValue;

        public string Titel
        {
            get
            {
                return titelValue;
            }
            set
            {
                if (value != null)
                    titelValue = value;
            }
        }
        public string Auteur
        {
            get
            {
                return auteurValue;
            }
            set
            {
                if (value != null)
                    auteurValue = value;
            }
        }
        public decimal Aankoopprijs
        {
            get
            {
                return aankoopprijsValue;
            }
            set
            {
                if (value > 0m)
                    aankoopprijsValue = value;
            }
        }

        public abstract decimal Winst
        {
            get;
        }

        public Genre Genre { get; set; }

        public Boek(string titel, string auteur, decimal prijs, Genre genre)
        {
            Titel = titel;
            Auteur = auteur;
            Aankoopprijs = prijs;
            Genre = genre;
        }

        public virtual string GegevensTonen()
        {
            return $"Titel: {Titel} \n" +
                $"Auteur: {Auteur} \n" +
                $"Eigenaar: {Eigenaar} \n" +
                $"Prijs: {Aankoopprijs} euro \n" +
                $"Winst: {Winst} euro \n" +
                Genre.ToString();
        }
    }
}
