﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public abstract class Gerecht : IBedrag
    {
        public string Naam { get; set; }
        public decimal StandaardPrijs { get; set; }

        public Gerecht(string naam, decimal prijs)
        {
            Naam = naam;
            StandaardPrijs = prijs;
        }

        public override string ToString() => $"Gerecht: {Naam} ({StandaardPrijs} euro) ";
        public virtual decimal BerekenBedrag()
        {
            return StandaardPrijs;
        }
    }
}
