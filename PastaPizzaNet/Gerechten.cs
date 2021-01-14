using System;
using System.Collections.Generic;
using System.Text;

namespace PastaPizzaNet
{
    public class Gerechten
    {
        public List<Gerecht> GerechtenLijst()
        {
            Pizza pizzaMargherita = new Pizza("Pizza Margherita", 8m, new List<string> { "tomatensaus", "mozzarella" });
            Pizza pizzaNapoli = new Pizza("Pizza Napoli", 10m, new List<string> { "tomatensaus", "mozzarella", "ansjovis", "kappers", "olijven" });
            Pizza pizzaLardiera = new Pizza("Pizza Lardiera", 9.5m, new List<string> { "tomatensaus", "mozzarella", "spek" });
            Pizza pizzaVegetariana = new Pizza("Pizza Vegetariana", 9.5m, new List<string> { "tomatensaus", "mozzarella", "groenten" });
            Pasta spaghettiBolognese = new Pasta("Spaghetti Bolognese", 12m, "met gehaktsaus");
            Pasta spaghettiCarbonara = new Pasta("Spaghetti Carbonara", 13m, "spek, roomsaus en parmezaanse kaas");
            Pasta penneArrabiata = new Pasta("Penne Arrabiata", 14m, "met pittige tomatensaus");
            Pasta lasagne = new Pasta("Lasagne", 15m, string.Empty);
            return new List<Gerecht> { pizzaMargherita, pizzaNapoli, pizzaLardiera, pizzaVegetariana, spaghettiBolognese, spaghettiCarbonara, penneArrabiata, lasagne };
        }
    }
}