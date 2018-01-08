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


        private float cupBundleOne;
        private float cupBundleTwo;
        private float cupBundleThree;

        private float sugarBundleOne;
        private float sugarBundleTwo;
        private float sugarBundleThree;

        private float lemonBundleOne;
        private float lemonBundleTwo;
        private float lemonBundleThree;

        private float iceBundleOne;
        private float iceBundleTwo;
        private float iceBundleThree;

        private float cupBundleOnePrice;
        private float cupBundleTwoPrice;
        private float cupBundleThreePrice;

        private float lemonBundleOnePrice;
        private float lemonBundleTwoPrice;
        private float lemonBundleThreePrice;

        private float sugarBundleOnePrice;
        private float sugarBundleTwoPrice;
        private float sugarBundleThreePrice;

        private float iceBundleOnePrice;
        private float iceBundleTwoPrice;
        private float iceBundleThreePrice;


        //constructor
        public Store()
        {


            cupBundleOnePrice = 2.00f;
            cupBundleTwoPrice = 2.25f;
            cupBundleThreePrice = 3.00f;

            cupBundleOne = 50f;
            cupBundleTwo = 75f;
            cupBundleThree = 100f;

            lemonBundleOne = 8f;
            lemonBundleTwo = 30f;
            lemonBundleThree = 50f;

            lemonBundleOnePrice = 2.00f;
            lemonBundleTwoPrice = 2.25f;
            lemonBundleThreePrice = 3.00f;

            sugarBundleOne = 10f;
            sugarBundleTwo = 15f;
            sugarBundleThree = 25f;

            sugarBundleOnePrice = 2.00f;
            sugarBundleTwoPrice = 2.25f;
            sugarBundleThreePrice = 3.00f;

            iceBundleOne = 100f;
            iceBundleTwo = 250f;
            iceBundleThree = 500f;

            iceBundleOnePrice = 2.00f;
            iceBundleTwoPrice = 2.50f;
            iceBundleThreePrice = 3.50f;


        }

        //member methods 

        //Techincally not SOLID but we're rolling with it.
        //Game needs option to skip this step

        public void GetCupBundle(Player user, Game game)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - cupBundleOnePrice;
                    user.inventory.Cups = user.inventory.Cups + cupBundleOne;
                    game.CommandCenter(user, this);
                    break;
                    
                case "2":
                    user.Money = user.Money - cupBundleTwoPrice;
                    user.inventory.Cups = user.inventory.Cups + cupBundleTwo;
                    game.CommandCenter(user, this);
                    break;
                case "3":
                    user.Money = user.Money - cupBundleThreePrice;
                    user.inventory.Cups = user.inventory.Cups + cupBundleThree;
                    game.CommandCenter(user, this);
                    break;
                case "4":
                    game.CommandCenter(user, this);
                    break;
                default:
                    break;
                    
            }
        }
        public void GetLemonBundle(Player user, Game game)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - lemonBundleOnePrice;
                    user.inventory.Lemons = user.inventory.Lemons + lemonBundleOne;
                    game.CommandCenter(user, this);
                    break;

                case "2":
                    user.Money = user.Money - lemonBundleTwoPrice;
                    user.inventory.Lemons = user.inventory.Lemons + lemonBundleTwo;
                    game.CommandCenter(user, this);
                    break;

                case "3":
                    user.Money = user.Money - lemonBundleThreePrice;
                    user.inventory.Lemons = user.inventory.Lemons + lemonBundleThree;
                    game.CommandCenter(user, this);
                    break;
                case "4":
                    game.CommandCenter(user, this);
                    break;
            }
        }

        public void GetSugarBundle(Player user, Game game)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - sugarBundleOnePrice;
                    user.inventory.CupsOfSugar = user.inventory.CupsOfSugar + sugarBundleOne;
                    game.CommandCenter(user, this);
                    break;
                case "2":
                    user.Money = user.Money - sugarBundleTwoPrice;
                    user.inventory.CupsOfSugar = user.inventory.CupsOfSugar + sugarBundleTwo;
                    game.CommandCenter(user, this);
                    break;
                case "3":
                    user.Money = user.Money - sugarBundleThreePrice;
                    user.inventory.CupsOfSugar = user.inventory.CupsOfSugar + sugarBundleThree;
                    game.CommandCenter(user, this);
                    break;
                case "4":
                    game.CommandCenter(user, this);
                    break;
            }
        }

        public void GetIceBundle(Player user, Game game)
        {
            switch (game.GetUserInput())
            {
                case "1":
                    user.Money = user.Money - iceBundleOnePrice;
                    user.inventory.IceCubes = user.inventory.IceCubes + iceBundleOne;
                    game.CommandCenter(user, this);
                    break;
                case "2":
                    user.Money = user.Money - iceBundleTwoPrice;
                    user.inventory.IceCubes = user.inventory.IceCubes + iceBundleTwo;
                    game.CommandCenter(user, this);
                    break;
                case "3":
                    user.Money = user.Money - iceBundleThreePrice;
                    user.inventory.IceCubes = user.inventory.IceCubes + iceBundleThree;
                    game.CommandCenter(user, this);
                    break;
                case "4":
                    game.CommandCenter(user, this);
                    break;
            }
        }
        
    }
}
