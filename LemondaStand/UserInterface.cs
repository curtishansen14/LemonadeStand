using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        //member variables


        //constructor


        //member methods 

        public static void DisplayInstructions()
        {
            Console.WriteLine("Let's Play Lemonade Stand");
            Console.WriteLine("You are the proud owner of a Lemonade Stand.");
            Console.WriteLine("You have 7 days to make as much money as possible.");
            Console.WriteLine("You will make your own recipe, buy inventory, and set prices daily.");
            Console.WriteLine("Weather will effect demand so be sure pay attention to the daily forecast.");
            Console.ReadKey();
        }

    }
}
