﻿using System;
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
            day.GetForeCast();
            weather.GetConditions(day);
            for (int i = 0; i<= 2; i++)
            {
                //get daily forcast
                //get daily weather
                CommandCenter(user, store, day);
                Console.WriteLine("Day change");

            }


        }

        public string GetUserInput()
        {
            userInput = Console.ReadLine();
            return userInput;
        }

        public void CommandCenter(Player user, Store store, Day day)
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
            Console.WriteLine(" Today is day: "); //need to display day);
            Console.WriteLine(" Todays forecast: " + day.GenerateForecastedTemperature() );
            Console.WriteLine(" ");
            Console.WriteLine(" Press G to begin");
            Console.WriteLine(" Press S to go to the store.");
            Console.WriteLine(" *************** ************** *************** ");
            

            switch (GetUserInput())
            {
                case "g":
                    Console.WriteLine("Today started");
                    //call customers aka go to market
                    //turnEarth();
                    return;
                case "s":
                    UserInterface.offerInventory(user, store, this, day);
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
