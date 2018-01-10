using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //SOLID Principle: Open/Closed 
        //New functionality can be added to player class without changing functionality of existing code
        

        //member variables
        public Inventory inventory;
        private double money;
        private double price;


        //constructor
        public Player()
        {
            inventory = new Inventory();
            money = 20.00;
            price = 1.00;

            lemonsPerCup = 1;
            sugarPerCup = 1;
            iceCubesPerCup = 2;

        }

        //member methods 
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }   
           
        public double setPrice(Game game)
        {
            Price = Convert.ToDouble(game.GetUserInput());
            
            return Price;
        }



        //member variables
        private double lemonsPerCup;
        private double sugarPerCup;
        private double iceCubesPerCup;


        //constructor


        //member methods 
        


        public double SetLemonsPerCup(Game game)
        {
            LemonsPerCup = Convert.ToDouble(game.GetUserInput());
            return LemonsPerCup;
        }
        public double SetSugarPerCup(Game game)
        {
            SugarPerCup = Convert.ToDouble(game.GetUserInput());
            return SugarPerCup;
        }
        public double SetIceCubesPerCup(Game game)
        {
            IceCubesPerCup = Convert.ToDouble(game.GetUserInput());
            return IceCubesPerCup;
        }

        public double LemonsPerCup
        {
            get { return lemonsPerCup; }
            set { lemonsPerCup = value; }
        }

        public double SugarPerCup
        {
            get { return sugarPerCup; }
            set { sugarPerCup = value; }
        }

        public double IceCubesPerCup
        {
            get { return iceCubesPerCup; }
            set { iceCubesPerCup = value; }
        }
    }

}
