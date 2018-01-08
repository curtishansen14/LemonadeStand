using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        private int forecast;
        private int temperature;
        private Weather Weather;
        private Customer customers;
        private Random random;

        //constructor
        public Day(Random rnd)
        {
            random = rnd;
        }

        //member methods 
        public int getForecast()
        {
            forecast = random.Next(1, 6);
            return forecast;
        }

        public int getTemperature()
        {
            temperature = random.Next(60, 101);
            return temperature;
        }
        //public int getWeather()
        //{
        //    Weather = random.Next()
        //}
        public int displayForeCast()
        {
            switch (getForecast())
            {
                case 1:
                    Console.WriteLine("Forecast: Rain");
                    return forecast;

                case 2:
                    Console.WriteLine("Forcast: Overcast");
                    return forecast;
                case 3:
                    Console.WriteLine("Forecast: Partly Cloudy");
                    return forecast;
                case 4:
                    Console.WriteLine("Forecast: Clear Skys");
                    return forecast;
                case 5:
                    Console.WriteLine("Forecast: Sunny");
                    return forecast;
                default:
                    return forecast;
            }
        }
    }
}
