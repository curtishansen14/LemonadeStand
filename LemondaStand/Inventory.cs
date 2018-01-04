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
        private float cups;
        private float cupsofsugar;
        private float lemons;
        private float icecubes;


        //constructor
        public Inventory()
        {

        }

        //member methods 


        public float Cups
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
        public float CupsOfSugar
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
        public float Lemons
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
        public float IceCubes
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
