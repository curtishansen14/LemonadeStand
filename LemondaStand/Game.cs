using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Game
    {
        //member variables (HAS A)
        Random rnd = new Random();
        Player user;
        Store store;
        Day day;
        private int daysElipsed;


        //constructor
        public Game()
        {
            user = new Player();
            store = new Store();
            day = new Day();
            daysElipsed = 0;
        }

        //member methods 
        public void RunGame()
        {
            UserInterface.DisplayInstructions();
            UserInterface.CommandCenter(user, store);
        }
        
        public void DayCycle()
        {
            UserInterface.DisplayInstructions();
            while (daysElipsed < 7)
            {
                UserInterface.CommandCenter(user, store);
                UserInterface.offerInventory(user, store);


            }
        }
        public int DaysElipsed
        {
            get
            {
                return daysElipsed;
            }
            set
            {
                daysElipsed = value;
            }
        }
       
    }
}
