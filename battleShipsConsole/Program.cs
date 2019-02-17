using System;
using System.Collections.Generic;

namespace battleShipsConsole
{
   public class Program
    {

        static void Main(string[] args)
        {
            GameLogic gameLogic = new GameLogic();

            Console.WriteLine("Welcome to the Battleship");
            Console.WriteLine("Coordinates start at 0!");
            Console.WriteLine("M = MISS, H = HIT ");

            gameLogic.SetupMap();
            Console.ReadLine();
        }

    }
}
