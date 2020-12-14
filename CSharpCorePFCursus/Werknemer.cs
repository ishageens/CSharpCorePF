using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Werknemer
    {
        private string naamValue;
        public string Naam
        {
            get { return naamValue; }
            set {
                if (value != string.Empty)
                    naamValue = value; }
        }

        private DateTime inDienstValue;
        public DateTime InDienst
        {
            get { return inDienstValue; }
            set { inDienstValue = value; }
        }

        private Geslacht geslachtValue;
        public Geslacht Geslacht
        {
            get { return geslachtValue; }
            set { geslachtValue = value; }
        }
    }
}
