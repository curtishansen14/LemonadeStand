using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Game
    {
        //member variables (HAS A)
        Random rnd = new Random();
        Player user;
        Store store;
        Day day;
        private int daysElipsed;
        private string userInput;


        //constructor
        public Game()
        {
            user = new Player();
            store = new Store();
            day = new Day(rnd);
            daysElipsed = 0;
        }

        //member methods 
        
        public void RunGameCycle()
        {
            UserInterface.DisplayInstructions();

            for (int DaysElipsed = 0; DaysElipsed < 7; DaysElipsed++)
            {
                CommandCenter(user, store);
                // UserInterface.offerInventory(user, store, this);


            }
        }

        public string GetUserInput()
        {
            userInput = Console.ReadLine();
            return userInput;
        }

        public void CommandCenter(Player user, Store store)
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
            Console.WriteLine(" Today is day: " + daysElipsed);
            Console.WriteLine(" Todays forecast: ");
            Console.WriteLine(" ");
            Console.WriteLine(" Press G to begin");
            Console.WriteLine(" Press S to go to the store.");
            Console.WriteLine(" *************** ************** *************** ");
            

            switch (GetUserInput())
            {
                case "g":
                    //calls the customers 
                    turnEarth();
                    CommandCenter(user, store);
                    break;
                case "s":
                    UserInterface.offerInventory(user, store, this);
                    break;
                case "p":
                    //set price
                    break;
                case "r":
                    // set recipe
                    break;
                default:
                    Console.WriteLine("Please try again");
                    Console.WriteLine("Be sure to use lower case");
                    break;


            }
        }

        public void turnEarth()
        {
            daysElipsed = daysElipsed++;
        }
        public int DaysElipsed
        {
            get
            {return daysElipsed;}
            set
            {daysElipsed = value;}
        }
       
    }
}
