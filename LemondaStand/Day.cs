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
        public string GenerateForecast()
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
        
        public int GenerateForecastedTemperature()
        {
            foreCastedtemperature = random.Next(60, 101);
            return foreCastedtemperature;
        }

        //public int GetForeCast()
        //{
        //    switch (GenerateForecast() )
        //    {
        //        case 1:
        //            Console.WriteLine(" Today's forecast Rain");
        //            return skyConditions;
                    
                    
        //        case 2:
        //            Console.WriteLine(" Today's forecast Overcast");
        //            return skyConditions;
        //        case 3:
        //            Console.WriteLine(" Today's forecast Partly Cloudy");
        //            return skyConditions;
        //        case 4:
        //            Console.WriteLine(" Today's forecast Clear Skys");
        //            return skyConditions;
        //        case 5:
        //            Console.WriteLine(" Today's forecast Sunny");
        //            return skyConditions;
        //        default:
        //            return skyConditions;
        //    }
        //}
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
