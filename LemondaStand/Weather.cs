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
        private Random rnd;

        //constructor
        public Weather()
        {
            conditions = 1;
            weather = 1;
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

        private int GetConditions(Day day)
        {
            switch (day.SkyConditions)
            {
                case 1:
                    conditions = rnd.Next(1, 3);
                    return conditions;
                case 2:
                    conditions = rnd.Next(1, 4);
                    return conditions;
                case 3:
                    conditions = rnd.Next(2, 5);
                    return conditions;
                case 4:
                    conditions = rnd.Next(3,6);
                    return conditions;
                case 5:
                    conditions = rnd.Next(3, 6);
                    return conditions;
                default:
                    conditions = rnd.Next(1, 6);
                    return conditions;

            }
        }
    }
}
