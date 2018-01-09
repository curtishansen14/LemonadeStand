using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
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
    }
}
