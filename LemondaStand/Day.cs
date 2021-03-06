﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        private string skyConditions;
        private double foreCastedtemperature;

        //constructor
        public Day(Random random)
        {
            skyConditions = GenerateForecast(random);
            foreCastedtemperature = GenerateForecastedTemperature(random);
        }

        //member methods 
        public string GenerateForecast(Random random)
        {
            int result;
            List<string> skyConditions = new List<string>();
            skyConditions.Add("Rain");
            skyConditions.Add("Overcast");
            skyConditions.Add("Partly Cloudy");
            skyConditions.Add("Clear Skys");
            skyConditions.Add("Sunny");
            result = random.Next(0, skyConditions.Count - 1);
            return skyConditions[result].ToString();
        }
        
        public double GenerateForecastedTemperature(Random random)
        {
            foreCastedtemperature = random.Next(60, 101);
            return foreCastedtemperature;
        }


        public string SkyConditions
        {
            get { return skyConditions; }
            set { skyConditions = value; }
        }
        public double ForecastedTemperature
        {
            get { return foreCastedtemperature; }
            set { foreCastedtemperature = value; }
        }

        public void DisplayForeCastedTemperature()
        {
            Console.WriteLine("Forecasted Temperature: " + ForecastedTemperature);
        }

        public List<Customer>AddCustomersToList(Weather weather, Day day, Random random, Player user, Inventory inventory)
        {
            List<Customer> Customers = new List<Customer>();
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer(weather, day, random, user, inventory);
                    Customers.Add(customer);
            }
            return Customers;
        }
    }


}
