using System;
using System.Collections.Generic;
using System.Text;

namespace BoekBoekenrek
{
    class Boekenrek : IVoorwerpen
    {
        private float hoogteValue;
        private float breedteValue;
        private decimal aankoopprijsValue;
        public float Hoogte
        {
            get
            {
                return hoogteValue;
            }
            set
            {
                if (value > 0f)
                    hoogteValue = value;
            }
        }
        public float Breedte
        {
            get
            {
                return breedteValue;
            }
            set
            {
                if (value > 0f)
                    breedteValue = value;
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

        public Boekenrek(float hoogte, float breedte, decimal aankoopprijs)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            Aankoopprijs = aankoopprijs;
        }

        public decimal Winst
        {
            get
            {
                return Aankoopprijs * 2;
            }
        }

        public string GegevensTonen()
        {
            return string.Format(
                $"Boekenrek \n" +
                $"--------- \n" +
                $"Hoogte: {Hoogte} \n" +
                $"Breedte: {Breedte} \n" +
                $"Aankoopprijs: {Aankoopprijs} euro \n" +
                $"Winst: {Winst} euro \n");
        }
    }
}
