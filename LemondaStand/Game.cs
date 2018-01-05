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
            day = new Day();
            daysElipsed = 0;
        }

        //member methods 
        
        public void RunGameCycle()
        {
            UserInterface.DisplayInstructions();
            while (daysElipsed < 7)
            {
                CommandCenter(user, store);
                UserInterface.offerInventory(user, store, this);


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
            Console.WriteLine(" Today is: ");
            Console.WriteLine(" Todays forecast: ");
            Console.WriteLine(" ");
            Console.WriteLine(" Press G to begin");
            Console.WriteLine(" Press S to go to the store.");
            Console.WriteLine(" *************** ************** *************** ");
            Console.ReadKey();

            switch (GetUserInput())
            {
                case "g":
                    //calls the customers 
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
        public int DaysElipsed
        {
            get
            {
                return daysElipsed;
            }
            set
            {
                daysElipsed = value;
            }
        }
       
    }
}
