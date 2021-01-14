using System;
using System.Collections.Generic;


namespace PastaPizzaNet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gerecht> gerechtenLijst = new Gerechten().GerechtenLijst();
            Klant klant1 = new Klant(1, "Jan Janssens");
            Gerecht gerecht = gerechtenLijst[0];
            BesteldGerecht besteldGerecht = new BesteldGerecht(gerecht, Grootte.Klein, Extras.Brood);
            Drank drinken = new Drank(DrankenLijst.Cocacola);
            Dessert dessert = new Dessert(DessertenLijst.Tiramisu);
            Bestelling bestelling1 = new Bestelling(klant1, besteldGerecht, drinken, dessert, 2);
            Console.WriteLine(bestelling1);

        }
    }
}
