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
        public void BuyCupofLemonade(Player user, Inventory inventory)
        {
            user.Money = user.Money - user.Price;
            user.inventory.Cups = user.inventory.Cups - 1;
            user.inventory.CupsOfSugar = user.inventory.CupsOfSugar - user.SugarPerCup;
            user.inventory.Lemons = user.inventory.Lemons - user.LemonsPerCup;
            user.inventory.IceCubes = user.inventory.IceCubes - user.IceCubesPerCup;
        }
    }
}
