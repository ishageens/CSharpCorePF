﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    [Serializable]
    public class Tweet
    {
        public Tweet()
        {
            this.Tijdstip = DateTime.Now;
        }
        public string Naam { get; set; }

        private string berichtValue;
        public string Bericht
        {
            get
            {
                return berichtValue;
            }
            set
            {
                if (value.Length <= 280)
                {
                    berichtValue = value;
                }
                else
                {
                    berichtValue = value.Substring(0, 280);
                }
            }
        }
        public DateTime Tijdstip { get; }

        public override string ToString()
        {
            StringBuilder tweet = new StringBuilder($"{Naam}: {Bericht}: ");
            TimeSpan verschil = DateTime.Now - this.Tijdstip;
            if (verschil.Days > 0)
                tweet.Append(this.Tijdstip.ToShortDateString());
            else if (verschil.Hours > 0)
                tweet.Append(verschil.Hours + "uur geleden");
            else if (verschil.Minutes > 0)
                tweet.Append(verschil.Minutes + (verschil.Minutes == 1 ? "minuut" : "minuten") + " geleden");
            else
                tweet.Append(this.Tijdstip.ToShortTimeString());
            return tweet.ToString();
        }
    }
}
