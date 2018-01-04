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
        private Inventory marketplace;

        private string cupBundle;

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

        private string NOREDLINE;


        //constructor
        public Store()
        {
            marketplace = new Inventory();
            marketplace.Cups = 1000;
            marketplace.CupsOfSugar = 1000;
            marketplace.Lemons = 1000;
            marketplace.IceCubes = 10000;

            cupBundleOnePrice = 2.00f;

            cupBundleOne = 50f;
            cupBundleTwo = 75f;
            cupBundleThree = 100f;

        }

        //member methods 

        public string GetCupBundleChioce()
        {
            UserInterface.DisplayCupPrices();
            cupBundle = Console.ReadLine();
            return cupBundle;
        }

        //Techincally not SOLID but we're rolling with it.
        public void GetCupBundle(Player user)
        {
            switch (GetCupBundleChioce())
            {
                case "1":
                    user.Money = user.Money - cupBundleOnePrice;
                    user.inventory.Cups = user.inventory.Cups + cupBundleOne;
                    break;
                    
                case "2":
                    
                case "3":
                   
                case "0":
                    
                default:
                    break;
                    
            }
        }
    }
}
