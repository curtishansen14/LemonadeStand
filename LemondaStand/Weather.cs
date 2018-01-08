using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
      
        private double actualWeather;
        private int weatherMultiplier;
        private Random random;

        //constructor
        public Weather(Random rnd)
        {
   
            actualWeather = 44;
            weatherMultiplier = 0;
            random = rnd;
            
        }

        //member methods 


        public double GetWeather(Day day)
        {
            GetWeatherMultiplier();

            if (weatherMultiplier == 1)
            {
                actualWeather = day.ForecastedTemperature * 1.1;
                return actualWeather;
            }
            else if (weatherMultiplier == 2)
            {
                actualWeather = day.ForecastedTemperature * .9;
                return actualWeather;
            }
            else
            {
                actualWeather = day.ForecastedTemperature;
                return actualWeather;
            }
            
        }

        public double ActualWeather
        {
            get { return actualWeather; }

        }
        


    public int GetWeatherMultiplier()
    {
        weatherMultiplier = random.Next(1, 2);
        return weatherMultiplier;
    }
    }
}
