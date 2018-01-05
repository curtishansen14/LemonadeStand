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


        //constructor
        public Game()
        {
            user = new Player();
            store = new Store();
        }

        //member methods 
        public void RunGame()
        {
            UserInterface.DisplayInstructions();
            UserInterface.CommandCenter(user);
            
            
        }

    }
}
