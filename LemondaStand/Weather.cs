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
        private int weather;
        private Random random;

        //constructor
        public Weather(Random rnd)
        {
            conditions = 1;
            weather = 1;
            random = rnd;
            
        }

        //member methods 
        public int Conditions
        {
            get { return conditions; }
            set { conditions = value; }
        }
        public int ActualWeather
        {
            get { return weather; }
            set { weather = value; }
        }

        public int GetConditions(Day day)
        {
            switch (day.SkyConditions)
            {
                case 1:

                    conditions = random.Next(1, 3);
                    return conditions;
                case 2:
                    conditions = random.Next(1, 4);
                    return conditions;
                case 3:
                    conditions = random.Next(2, 5);
                    return conditions;
                case 4:
                    conditions = random.Next(3,6);
                    return conditions;
                case 5:
                    conditions = random.Next(3, 6);
                    return conditions;
                default:
                    conditions = random.Next(1, 6);
                    return conditions;

            }
        }
    }
}
