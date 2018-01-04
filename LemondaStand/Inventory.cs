using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        private int cups;
        private int cupsofsugar;
        private int lemons;
        private int icecubes;


        //constructor
        public Inventory()
        {

        }

        //member methods 

       /* public void DisplayInventory()
        {
            Console.WriteLine("{0} cups.", cups);
            Console.WriteLine("{0} lemons.", lemons);
            Console.WriteLine("{0} cups of sugar.", cupsofsugar);
            Console.WriteLine("{0} ice cubes.",icecubes);
            Console.ReadKey();
        }
        */
        public int Cups
        {
            get
            {
                return cups;
            }
            set
            {
                cups = value;
            }
        }
        public int CupsOfSugar
        {
            get
            {
                return cupsofsugar;
            }
            set
            {
                cupsofsugar = value;
            }
        }
        public int Lemons
        {
            get
            {
                return lemons;
            }
            set
            {
                lemons = value;
            }
        }
        public int IceCubes
        {
            get
            {
                return icecubes;
            }
            set
            {
                icecubes = value;
            }
        }
    }
}
