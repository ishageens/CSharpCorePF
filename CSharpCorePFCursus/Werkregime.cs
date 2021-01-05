using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public abstract partial class Werknemer
    {
        public class WerkRegime
        {
            public enum RegimeType
            {
                Voltijds,
                Viervijfde,
                Halftijds
            }

            public RegimeType Type { get; set; }

            public int AantalVakantieDagen
            {
                get
                {
                    switch (Type)
                    {
                        case RegimeType.Voltijds:
                            return 25;
                        case RegimeType.Viervijfde:
                            return 20;
                        case RegimeType.Halftijds:
                            return 12;
                        default:
                            return 0;
                    }
                }
            }
            public WerkRegime(RegimeType type)
            {
                Type = type;
            }
            public override string ToString()
            {
                return Type.ToString();
            }
        }

        public WerkRegime Regime { get; set; }
    }
}
