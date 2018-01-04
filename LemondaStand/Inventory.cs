using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables
        public int cups;
        public int cupsofsugar;
        public int lemons;
        public int icecubes;


        //constructor
        public Inventory()
        {
            cups = 0;
            cupsofsugar = 0;
            lemons = 0;
            icecubes = 0;
        }

        //member methods 
        public void DisplayInventory()
        {
            Console.WriteLine("{0} cups.", cups);
            Console.WriteLine("{0} lemons.", lemons);
            Console.WriteLine("{0} cups of sugar.", cupsofsugar);
            Console.WriteLine("{0} ice cubes.",icecubes);
            Console.ReadKey();
        }

    }
}
