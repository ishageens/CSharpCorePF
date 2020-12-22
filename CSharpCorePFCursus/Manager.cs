using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Manager : Bediende
    {
        public Manager(string naam, DateTime indienst, Geslacht geslacht,
        decimal wedde, decimal bonus)
        : base(naam, indienst, geslacht, wedde)
        {
            Bonus = bonus;
        }
        private decimal bonusValue;
        public decimal Bonus
        {
            get
            {
                return bonusValue;
            }
            set
            {
                if (value > 0m)
                    bonusValue = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Bonus: {Bonus}";
        }
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Bonus: {Bonus}");
        }
    }
}