﻿using System;
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

        public static void CommandCenter(Player user )
        {
            Console.WriteLine(" ");
            Console.WriteLine(" *************** Command Center *************** ");
            Console.WriteLine("  Cups: " + user.inventory.Cups);
            Console.WriteLine("  Cups of Sugar: " + user.inventory.CupsOfSugar);
            Console.WriteLine("  Lemons: " + user.inventory.Lemons);
            Console.WriteLine("  Ice Cubes: " + user.inventory.IceCubes);
            Console.WriteLine(" ");
            Console.WriteLine(" Money " + user.Money);
            Console.WriteLine(" Today is: ");
            Console.WriteLine(" Todays forecase: ");

            Console.ReadKey();
        }

        public static void DisplayCupPrices()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Which cup bundle would you like?");
            Console.WriteLine(" 1. $2.00 for 50 cups");
            Console.WriteLine(" 2. $2.25 for 75 cups");
            Console.WriteLine(" 3. $3.00 for 100 cups");
        }
    }
}
