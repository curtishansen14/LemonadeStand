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
        Weather weather;
        private int daysElipsed;
        private string userInput;


        //constructor
        public Game()
        {
            user = new Player();
            store = new Store();
            day = new Day(rnd);
            weather = new Weather(rnd);
            daysElipsed = 0;
        }

        //member methods 

        public void RunGameCycle()
        {
            UserInterface.DisplayInstructions();

            
            for (int i = 0; i<= 6; i++)
            {
                //get daily forcast
                //get daily weather
                Console.WriteLine(" ");
                Console.WriteLine("^^^^^^^Weather Forecast^^^^^^^^^");
                Console.WriteLine(" ");
                Console.WriteLine(" Today's forecast: " + day.GenerateForecastedTemperature() + " and " + day.GenerateForecast());
                Console.WriteLine(" ");
                Console.WriteLine(" Day: " + ( i + 1));
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                CommandCenter(user, store, day, weather);
                Console.WriteLine(" Day change");

            }


        }

        public string GetUserInput()
        {
            userInput = Console.ReadLine();
            return userInput;
        }

        public void CommandCenter(Player user, Store store, Day day, Weather weather)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" *************** Command Center *************** ");
            Console.WriteLine(" ");
            Console.WriteLine("  Cups: " + user.inventory.Cups);
            Console.WriteLine("  Cups of Sugar: " + user.inventory.CupsOfSugar);
            Console.WriteLine("  Lemons: " + user.inventory.Lemons);
            Console.WriteLine("  Ice Cubes: " + user.inventory.IceCubes);
            Console.WriteLine(" ");
            Console.WriteLine(" Price $" + user.Price);
            Console.WriteLine(" Money $" + user.Money);
            Console.WriteLine(" ");
            Console.WriteLine(" Recipe:");
            Console.WriteLine(" " + user.LemonsPerCup + " Lemons per a cup");
            Console.WriteLine(" " + user.IceCubesPerCup + " Ice Cubes per a Cup");
            Console.WriteLine(" " + user.SugarPerCup + " Sugar per a cup");
            Console.WriteLine(" ");
            Console.WriteLine(" Press G to begin");
            Console.WriteLine(" Press S to go to the store.");
            Console.WriteLine(" Press P to change price");
            Console.WriteLine(" Press R to change recipe");
            Console.WriteLine(" *************** ************** *************** ");
            

            switch (GetUserInput())
            {
                case "g":
                    weather.GetWeather(day);
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" Lets go to market");
                    Console.WriteLine(" Today's weather " + weather.ActualWeather + " degrees" );
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------------------------------");
                    //call customers aka go to market
                    return;
                case "s":
                    UserInterface.offerInventory(user, store, this, day, weather);
                    break;
                case "p":
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter price of Lemonade");
                    user.setPrice(this);
                    UserInterface.DisplayPrice(user);
                    Console.WriteLine(" ");
                    CommandCenter(user, store, day, weather);

                    break;
                case "r":
                    Console.WriteLine(" ");
                    Console.WriteLine("");
                    UserInterface.offerRecipeChange(user, store, this, day, weather);
                    CommandCenter(user, store, day, weather);
                    // set recipe
                    break;
                default:
                    Console.WriteLine("Please try again");
                    Console.WriteLine("Be sure to use lower case");
                    break;


            }
        }

       
    }
}
