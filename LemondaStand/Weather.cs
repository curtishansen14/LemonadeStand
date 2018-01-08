using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        private int conditions;
        private double weather;
        private int weatherMultiplier;
        private Random random;

        //constructor
        public Weather(Random rnd)
        {
            conditions = 1;
            weather = 1;
            weatherMultiplier = 0;
            random = rnd;
            
        }

        //member methods 
        public int Conditions
        {
            get { return conditions; }
            set { conditions = value; }
        }
        public double ActualWeather
        {
            get { return weather; }
            set { weather = value; }
        }

        public double GetWeather(Day day)
        {

            if (weatherMultiplier == 1)
            {
                ActualWeather = day.ForecastedTemperature * 1.1;
                return ActualWeather;
            }
            else if (weatherMultiplier == 2)
            {
                ActualWeather = day.ForecastedTemperature * .9;
                return ActualWeather;
            }
            else
            {
                ActualWeather = day.ForecastedTemperature;
                return ActualWeather;
            }
            
        }
    public int GetWeatherMultiplier()
    {
        weatherMultiplier = random.Next(1, 2);
        return weatherMultiplier;
    }
    }
}
