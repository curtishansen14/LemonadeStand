using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Game
    {
        //member variables
        Player user;
        Random rnd = new Random();


        //constructor
        public Game()
        {
            user = new Player();
        }

        //member methods 
        public void RunGame()
        {
            UserInterface.DisplayInstructions();
            UserInterface.Interface(user);
            
        }

    }
}
