using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShipsConsole
{
    class GameMap
    {
        public bool HasShip { get; set; }
        public int[] Rows = Enumerable.Range(0, 10).ToArray();
        public Map Map { get; set; }
        GameLogic GameLogic = new GameLogic();
        Player Player = new Player("Dean");
        Player Computer = new Player("Computer");

        public void DrawMap(int gridSize, Map grid)
        {
            for (int Row = 0; Row < gridSize; Row++)
            {
                Console.WriteLine();

                for (int Column = 0; Column < gridSize; Column++)
                {
                    if (grid.CoordPositions[Column, Row] == 99)
                    {
                        Console.Write("H ");
                    }
                    else if (grid.CoordPositions[Column, Row] == 100)
                    {
                        Console.Write("M ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }

            }
            Console.WriteLine();
        }
    }
}
