﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand;

namespace LemondeStand
{
    class Recipe
    {
        //member variables


        //constructor
        public Recipe()
        {
            LemonsPerCup = 1;
            SugarPerCup = 1;
            IceCubesPerCup = 2;
        }

        //member methods 

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

