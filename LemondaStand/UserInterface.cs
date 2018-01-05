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

        public static void CommandCenter(Player user, Store store)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" *************** Command Center *************** ");
            Console.WriteLine(" ");
            Console.WriteLine("  Cups: " + user.inventory.Cups);
            Console.WriteLine("  Cups of Sugar: " + user.inventory.CupsOfSugar);
            Console.WriteLine("  Lemons: " + user.inventory.Lemons);
            Console.WriteLine("  Ice Cubes: " + user.inventory.IceCubes);
            Console.WriteLine(" ");
            Console.WriteLine(" Money " + user.Money);
            Console.WriteLine(" Today is: ");
            Console.WriteLine(" Todays forecast: ");
            Console.WriteLine(" ");
            Console.WriteLine(" Press G to begin");
            Console.WriteLine(" Press S to go to the store.");
            Console.WriteLine(" *************** ************** *************** ");
            Console.ReadKey();

            switch (store.GetUserInput())
            {
                case "g":
                    //calls the customers 
                    store.
                    CommandCenter(user, store);
                    break;
                case "s":
                    break;
                case "p":
                    //set price
                    break;
                case "r":
                    // set recipe
                    break;

                    
            }
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

        public static void offerInventory(Player user, Store store)
        {
            Console.WriteLine(" ");
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("C for cups");
            Console.WriteLine("S for sugar");
            Console.WriteLine("L for lemons");
            Console.WriteLine("I for ice");
            Console.WriteLine("E to exist to Command Center");
            
            //go to market? 
            //go to market will add Plus 1 to the daysEclipsed variable in game class

            switch (store.GetUserInput())
            {
                case "c":
                    DisplayCupPrices();
                    store.GetCupBundle(user);
                    break;
                case "s":
                    DisplaySugarPrices();
                    store.GetSugarBundle(user);
                    break;
                case "l":
                    DisplayLemonPrices();
                    store.GetLemonBundle(user);
                    break;
                case "i":
                    DisplayIcePrices();
                    store.GetIceBundle(user);
                    break;
                case "e":
                    CommandCenter(user);
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please try again.");
                    Console.WriteLine("Be sure to use lower case");
                    offerInventory(user, store);
                    break;
            }
        }
    }
}
