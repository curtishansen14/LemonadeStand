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
        private float money;

        //constructor
        public Player()
        {
            inventory = new Inventory();
            money = 20.00f;

        }

        //member methods 
        public float Money
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
    }
}
