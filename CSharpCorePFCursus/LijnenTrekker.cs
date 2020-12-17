using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    class LijnenTrekker
    {
        public void TrekLijn1(int lengte, char teken)
        {
            for (int teller = 0; teller < lengte; teller++)
                Console.Write(teken);
            Console.WriteLine();
        }

        public void TrekLijn2(int lengte)
        {
            for (int teller = 0; teller < lengte; teller++)
                Console.Write('-');
            Console.WriteLine();
        }

        public void TrekLijn3()
        {
            for (int teller = 0; teller < 80; teller++)
                Console.Write('-');
            Console.WriteLine();
        }
    }
}
