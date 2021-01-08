using System;
using System.Collections.Generic;
using System.Text;

namespace BoekBoekenrek
{
    public class Genre
    {
        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != null)
                    naamValue = value;
            }
        }

        public Doelgroep Doelgroep { get; set; }
        public Genre(string naam, Doelgroep doelgroep)
        {
            Naam = naam;
            Doelgroep = doelgroep;
        }
        public override string ToString()
        {
            return $"Genregegevens: \n" +
                $"  Genrenaam: {Naam} \n" +
                Doelgroep.ToString(); ;
        }
    }
}
