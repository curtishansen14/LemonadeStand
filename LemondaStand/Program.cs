using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {

        //SOLID Principles can be found in Weather and Player class
        static void Main(string[] args)
        {
            Game LemonadeStand = new Game();
            LemonadeStand.RunGameCycle();
        }
    }
}
