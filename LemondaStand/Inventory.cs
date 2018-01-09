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
        private double cups;
        private double cupsofsugar;
        private double lemons;
        private double icecubes;


        //constructor
        public Inventory()
        {

        }

        //member methods 


        public double Cups
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
        public double CupsOfSugar
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
        public double Lemons
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
        public double IceCubes
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
