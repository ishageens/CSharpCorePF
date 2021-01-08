﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Materiaal
{
    public class Fotokopiemachine : IKost
    {
        private int aantalGekopieerdeBlzValue;
        private decimal kostPerBlzValue;
        public string SerieNr { get; set; }
        public int AantalGekopieerdeBlz
        {
            get
            {
                return aantalGekopieerdeBlzValue;
            }
            set
            {
                if (value >= 0)
                    aantalGekopieerdeBlzValue = value;
            }
        }
        public decimal KostPerBlz
        {
            get
            {
                return kostPerBlzValue;
            }
            set
            {
                if (value > 0)
                    kostPerBlzValue = value;
            }
        }
        public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz,
        decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalGekopieerdeBlz = aantalGekopieerdeBlz;
            KostPerBlz = kostPerBlz;
        }
        public bool Menselijk
        {
            get
            {
                return false;
            }
        }
        public decimal Bedrag
        {
            get
            {
                return AantalGekopieerdeBlz * KostPerBlz;
            }
        }
    }
}