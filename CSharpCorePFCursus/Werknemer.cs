using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Werknemer
    {
        /*   public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
           {
           } 
        */
        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            this.Naam = naam;
            this.InDienst = inDienst;
            this.Geslacht = geslacht;
        }
        private string naamValue;
        public string Naam
        {
            get { return naamValue; }
            set
            {
                if (value != string.Empty)
                    naamValue = value;
            }
        }

        public DateTime InDienst { get; set; }
        public Geslacht Geslacht { get; set; }

        private decimal salarisValue;
        public decimal Salaris
        {
            get { return salarisValue; }
            private set
            {
                if (value >= 0m)
                    salarisValue = value;
            }
        }

        public bool VerjaarAncien
        {
            get
            {
                return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day;
            }
        }

        public void Afbeelden()
        {
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Geslacht: {Geslacht}");
            Console.WriteLine($"In dienst: {InDienst}");
        }
    }
}
