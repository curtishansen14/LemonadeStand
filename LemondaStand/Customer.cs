using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        private Random random;
        private double posssibleCustomers;
        private double customers;


        //constructor
        public Customer(Weather weather)
        {
            posssibleCustomers = weather.ActualWeather * 2;
        }

        //member methods 
        public double GetCustomers()
        {

            return customers;
        }
    }
}
