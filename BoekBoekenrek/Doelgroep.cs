using System;
using System.Collections.Generic;
using System.Text;

namespace BoekBoekenrek
{
    public class Doelgroep
    {
        private int leeftijdValue;

        public int Leeftijd
        {
            get
            {
                return leeftijdValue;
            }
            set
            {
                if (value > 0)
                    leeftijdValue = value;
            }
        }
        public string Categorie
        {
            get
            {
                if (Leeftijd > 0 && Leeftijd < 18)
                    return "Jeugd";
                else
                    return "Volwassenen";
            }
        }

        public Doelgroep(int leeftijd)
        {
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"Doelgroepgegevens: \n" +
                $" Leeftijd: {Leeftijd} \n" +
                $" Categorie: {Categorie} \n";
        }
    }
}
