using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        //member variables
        
        //constructor


        //member methods 

        public static void DisplayInstructions()
        {
            Console.WriteLine(" ");
            Console.WriteLine("  Let's Play Lemonade Stand");
            Console.WriteLine("  You are the proud owner of a Lemonade Stand.");
            Console.WriteLine("  You have 7 days to make as much money as possible.");
            Console.WriteLine("  You will make your own recipe, buy inventory, and set prices daily.");
            Console.WriteLine("  Weather will effect demand so be sure pay attention to the daily forecast.");
            Console.ReadKey();
        }

        

        public static void DisplayCupPrices()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Which bundle would you like?");
            Console.WriteLine(" 1. $2.00 for 50 cups");
            Console.WriteLine(" 2. $2.25 for 75 cups");
            Console.WriteLine(" 3. $3.00 for 100 cups");
            Console.WriteLine(" 4. return to Command Center");
        }

        public static void DisplayLemonPrices()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Which bundle would you like?");
            Console.WriteLine("1. $2.00 for 8 lemons");
            Console.WriteLine("2. $2.25 for 30 lemons");
            Console.WriteLine("3. $3.00 for 50 lemons");
            Console.WriteLine("4. return to Command Center");
        }

        public static void DisplaySugarPrices()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Which bundle would you like?");
            Console.WriteLine("1. $2.00 for 10 cups of sugar");
            Console.WriteLine("2. $2.25 for 15 cups of sugar");
            Console.WriteLine("3. $3.00 for 25 cups of sugar");
            Console.WriteLine("4. return to Command Center");
        }

        public static void DisplayIcePrices()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Which bundle would you like?");
            Console.WriteLine("1. $2.00 for 100 Ice Cubes");
            Console.WriteLine("2. $2.25 for 250 Ice Cubes");
            Console.WriteLine("3. $3.00 for 500 Ice Cubes");
            Console.WriteLine("4. return to Command Center");
        }

        public static void offerInventory(Player user, Store store, Game game)
        {
            Console.WriteLine(" ");
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("C for cups");
            Console.WriteLine("S for sugar");
            Console.WriteLine("L for lemons");
            Console.WriteLine("I for ice");
            Console.WriteLine("E to exist to Command Center");
            

            switch (game.GetUserInput())
            {
                case "c":
                    DisplayCupPrices();
                    store.GetCupBundle(user, game);
                    break;
                case "s":
                    DisplaySugarPrices();
                    store.GetSugarBundle(user, game);
                    break;
                case "l":
                    DisplayLemonPrices();
                    store.GetLemonBundle(user, game);
                    break;
                case "i":
                    DisplayIcePrices();
                    store.GetIceBundle(user, game);
                    break;
                case "e":
                    game.CommandCenter(user, store);
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please try again.");
                    Console.WriteLine("Be sure to use lower case");
                    offerInventory(user, store, game);
                    break;
            }
        }
    }
}
