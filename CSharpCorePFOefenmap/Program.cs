using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Twitter twitter = new Twitter();
            int keuze = MaakKeuze();
            while (keuze != 4)
            {
                string naam, bericht;
                try
                {
                    switch (keuze)

                    {

                        case 1:
                            Console.Write("Naam? ");
                            naam = Console.ReadLine();
                            Console.Write("Bericht? ");
                            bericht = Console.ReadLine();
                            Tweet tweet = new Tweet()

                            {
                                Naam = naam,

                                Bericht = bericht
                            };

                            twitter.SchrijfTweet(tweet);
                            break;
                        case 2:
                            var tweets = twitter.LeesAlleTweets();
                            foreach (var eenTweet in tweets)
                            {
                                Console.WriteLine(eenTweet);
                            }
                            break;
                        case 3:
                            Console.Write("Wie wil je volgen? ");
                            naam = Console.ReadLine();

                            var tweetsVan = twitter.LeesTweetsVan(naam);

                            if (tweetsVan.Count != 0)

                            {

                                foreach (var eenTweet in tweetsVan)
                                    Console.WriteLine(eenTweet);
                            }
                            else
                            {

                                Console.WriteLine("Geen tweets van {0}", naam);
                            }
                            break;

                    }

                    Console.WriteLine("-------------------------------");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                keuze = MaakKeuze();
            }
        }
        private static int MaakKeuze()
        {
            int keuze;
            Console.WriteLine("Maak een keuze:");
            Console.WriteLine("1 --> een twitterbericht plaatsen");
            Console.WriteLine("2 --> alle twitterberichten tonen");
            Console.WriteLine("3 --> twitterberichten van één persoon tonen");
            Console.WriteLine("4 --> stoppen");
            Console.Write("Keuze? ");
            while (!int.TryParse(Console.ReadLine(), out keuze)
            || (keuze != 1 && keuze != 2 && keuze != 3 && keuze != 4))
            {
                Console.WriteLine("Verkeerde keuze, geef een getal (1, 2, 3 of 4): ");
            }
            return keuze;
        }
    }
}
