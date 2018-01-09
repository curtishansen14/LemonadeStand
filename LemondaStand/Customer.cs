using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Customer
    {
        //member variables
        private double purchasePoints;
      


        //constructor
        public Customer(Weather weather, Day day, Random random, Player user, Inventory inventory)
        {
            purchasePoints = NeutralWillingnessToBuy(random);
            GetTemperatureEffect(weather);
            GetConditionsEffect(day);
            GetPriceEffect(user);
            BuyingDecision(purchasePoints, user, inventory);
        }

        //member methods 

        public void BuyCupofLemonade(Player user, Inventory inventory)
        {
            user.Money = user.Money + user.Price;
            user.inventory.Cups = user.inventory.Cups - 1;
            user.inventory.CupsOfSugar = user.inventory.CupsOfSugar - user.SugarPerCup;
            user.inventory.Lemons = user.inventory.Lemons - user.LemonsPerCup;
            user.inventory.IceCubes = user.inventory.IceCubes - user.IceCubesPerCup;
        }

        public bool BuyingDecision(double purchasePoints, Player user, Inventory inventory)
        {
            if (purchasePoints >= 75)
            {
                BuyCupofLemonade(user, inventory);
            }
            return false;
        }

        public double NeutralWillingnessToBuy(Random random)
        {
        purchasePoints = random.Next(50, 101);
            
            return purchasePoints;
        }

        public void GetTemperatureEffect(Weather weather)
        {
            if (weather.ActualWeather >= 90)
            {
                purchasePoints = purchasePoints + 15;
                return;
                
            } 
            else if (weather.ActualWeather >= 80)
            {
                purchasePoints = purchasePoints + 10;
                return;
               
            }
            else if (weather.ActualWeather >= 70)
            {
                purchasePoints = purchasePoints + 5;
                return;
            }

        }

        public void GetConditionsEffect(Day day)
        {
            switch (day.SkyConditions)
            {
                case "Rain":
                    purchasePoints = purchasePoints - 10;
                    break;
                case "Overcast":
                    purchasePoints = purchasePoints - 5;
                    break;
                case "Partly Cloudy":
                    purchasePoints = purchasePoints + 2;
                    break;
                case "Clear Skys":
                    purchasePoints = purchasePoints + 10;
                    break;
                case "Sunny":
                    purchasePoints = purchasePoints + 20;
                    break;
            }
                

        }
        public void GetPriceEffect(Player user)
        {
            if(user.Price > 2)
            {
                purchasePoints = purchasePoints - 10;
                return;
            }
            else if (user.Price > 1)
            {
                purchasePoints = purchasePoints - 5;
                return;
            }
            else if (user.Price == .25)
            {
                purchasePoints = purchasePoints + 15;
                return;
            }

        }

    }
}
