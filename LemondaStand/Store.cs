using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //member variables


        private double cupBundleOne;
        private double cupBundleTwo;
        private double cupBundleThree;

        private double sugarBundleOne;
        private double sugarBundleTwo;
        private double sugarBundleThree;

        private double lemonBundleOne;
        private double lemonBundleTwo;
        private double lemonBundleThree;

        private double iceBundleOne;
        private double iceBundleTwo;
        private double iceBundleThree;

        private double cupBundleOnePrice;
        private double cupBundleTwoPrice;
        private double cupBundleThreePrice;

        private double lemonBundleOnePrice;
        private double lemonBundleTwoPrice;
        private double lemonBundleThreePrice;

        private double sugarBundleOnePrice;
        private double sugarBundleTwoPrice;
        private double sugarBundleThreePrice;

        private double iceBundleOnePrice;
        private double iceBundleTwoPrice;
        private double iceBundleThreePrice;


        //constructor
        public Store()
        {


            cupBundleOnePrice = 2.00;
            cupBundleTwoPrice = 2.25;
            cupBundleThreePrice = 3.00;

            cupBundleOne = 50;
            cupBundleTwo = 75;
            cupBundleThree = 100;

            lemonBundleOne = 8;
            lemonBundleTwo = 30;
            lemonBundleThree = 50;

            lemonBundleOnePrice = 2.00;
            lemonBundleTwoPrice = 2.25;
            lemonBundleThreePrice = 3.00;

            sugarBundleOne = 10;
            sugarBundleTwo = 15;
            sugarBundleThree = 25;

            sugarBundleOnePrice = 2.00;
            sugarBundleTwoPrice = 2.25;
            sugarBundleThreePrice = 3.00;

            iceBundleOne = 100;
            iceBundleTwo = 250;
            iceBundleThree = 500;

            iceBundleOnePrice = 2.00;
            iceBundleTwoPrice = 2.50;
            iceBundleThreePrice = 3.50;


        }

        //member methods 

        //Techincally not SOLID but we're rolling with it.
        //Game needs option to skip this step

        public void GetCupBundle(Player user, Game game, Day day, Weather weather)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - cupBundleOnePrice;
                    user.inventory.Cups = user.inventory.Cups + cupBundleOne;
                    game.CommandCenter(user, this, day, weather);
                    break;
                    
                case "2":
                    user.Money = user.Money - cupBundleTwoPrice;
                    user.inventory.Cups = user.inventory.Cups + cupBundleTwo;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "3":
                    user.Money = user.Money - cupBundleThreePrice;
                    user.inventory.Cups = user.inventory.Cups + cupBundleThree;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "4":
                    game.CommandCenter(user, this, day, weather);
                    break;
                default:
                    break;
                    
            }
        }
        public void GetLemonBundle(Player user, Game game, Day day, Weather weather)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - lemonBundleOnePrice;
                    user.inventory.Lemons = user.inventory.Lemons + lemonBundleOne;
                    game.CommandCenter(user, this, day, weather);
                    break;

                case "2":
                    user.Money = user.Money - lemonBundleTwoPrice;
                    user.inventory.Lemons = user.inventory.Lemons + lemonBundleTwo;
                    game.CommandCenter(user, this, day, weather);
                    break;

                case "3":
                    user.Money = user.Money - lemonBundleThreePrice;
                    user.inventory.Lemons = user.inventory.Lemons + lemonBundleThree;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "4":
                    game.CommandCenter(user, this, day, weather);
                    break;
            }
        }

        public void GetSugarBundle(Player user, Game game, Day day, Weather weather)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - sugarBundleOnePrice;
                    user.inventory.CupsOfSugar = user.inventory.CupsOfSugar + sugarBundleOne;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "2":
                    user.Money = user.Money - sugarBundleTwoPrice;
                    user.inventory.CupsOfSugar = user.inventory.CupsOfSugar + sugarBundleTwo;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "3":
                    user.Money = user.Money - sugarBundleThreePrice;
                    user.inventory.CupsOfSugar = user.inventory.CupsOfSugar + sugarBundleThree;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "4":
                    game.CommandCenter(user, this, day, weather);
                    break;
            }
        }

        public void GetIceBundle(Player user, Game game, Day day, Weather weather)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - iceBundleOnePrice;
                    user.inventory.IceCubes = user.inventory.IceCubes + iceBundleOne;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "2":
                    user.Money = user.Money - iceBundleTwoPrice;
                    user.inventory.IceCubes = user.inventory.IceCubes + iceBundleTwo;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "3":
                    user.Money = user.Money - iceBundleThreePrice;
                    user.inventory.IceCubes = user.inventory.IceCubes + iceBundleThree;
                    game.CommandCenter(user, this, day, weather);
                    break;
                case "4":
                    game.CommandCenter(user, this, day, weather);
                    break;
            }
        }
        
    }
}
