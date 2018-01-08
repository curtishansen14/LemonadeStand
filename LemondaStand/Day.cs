using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        //member variables
        private int skyConditions;
        private int foreCastedtemperature;
        private Weather Weather;
        private Customer customers;
        private Random random;

        //constructor
        public Day(Random rnd)
        {
            random = rnd;
            skyConditions = 0;
            foreCastedtemperature = 0;
        }

        //member methods 
        public int GenerateForecast()
        {
            skyConditions = random.Next(1, 6);
            return skyConditions;
        }
        
        public int GenerateForecastedTemperature()
        {
            foreCastedtemperature = random.Next(60, 101);
            return foreCastedtemperature;
        }

        public int GetForeCast()
        {
            switch (GenerateForecast())
            {
                case 1:
                    Console.WriteLine("Forecast: Rain");
                    return skyConditions;

                case 2:
                    Console.WriteLine("Forcast: Overcast");
                    return skyConditions;
                case 3:
                    Console.WriteLine("Forecast: Partly Cloudy");
                    return skyConditions;
                case 4:
                    Console.WriteLine("Forecast: Clear Skys");
                    return skyConditions;
                case 5:
                    Console.WriteLine("Forecast: Sunny");
                    return skyConditions;
                default:
                    return skyConditions;
            }
        }
        public int SkyConditions
        {
            get { return skyConditions; }
            set { skyConditions = value; }
        }
        public int ForecastedTemperature
        {
            get { return foreCastedtemperature; }
            set { foreCastedtemperature = value; }
        }

        public void DisplayForeCastedTemperature()
        {
            Console.WriteLine("Forecasted Temperature: " + ForecastedTemperature);
        }
    }

}
