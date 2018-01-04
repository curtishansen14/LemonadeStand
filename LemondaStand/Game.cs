using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        private Player Human;



        //constructor
        public Game()
        {

        }

        //member methods 
        public void RunGame()
        {
            UserInterface.DisplayInstructions();

        }
    }
}
