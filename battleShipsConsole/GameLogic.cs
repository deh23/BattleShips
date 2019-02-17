using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShipsConsole
{
    public class GameLogic
    {
        Player Player = new Player("Dean");
        Player Computer = new Player("Computer");
        Random rnd = new Random();

        public int GridSize = 10;

        string Attack(Map grid, int xInput, int yInput, Player player)
        {
            string output;

            if (xInput > 10)
                xInput = 0;
            if (yInput > 10)
                yInput = 0;


            if (grid.CoordPositions[xInput, yInput] == 99 || grid.CoordPositions[xInput, yInput] == 100)
            {
                return "This has already been targeted by you.";
            }

            if (grid.CoordPositions[xInput, yInput] != 0)
            {
                player.Ships[grid.CoordPositions[xInput, yInput]].Hits += 1;

                if (player.Ships[grid.CoordPositions[xInput, yInput]].IsSunk)
                {
                    output = $"Hit you have sunk a {player.Ships[grid.CoordPositions[xInput, yInput]].ShipType}.";
                    grid.CoordPositions[xInput, yInput] = 99;
                }
                else
                {
                    output = "Hit";
                    grid.CoordPositions[xInput, yInput] = 99;
                }
            }
            else
            {
                output = "Miss";
                grid.CoordPositions[xInput, yInput] = 100;
            }
            grid.Value = output;
            return output;
        }

        void DrawShips(Map grid, Player player)
        {
            Coordinates coordinates = new Coordinates();
            Random rnd = new Random();
            for (int s = 0; s < player.Ships.Count(); s++)
            {
                do
                {
                    coordinates.Row = rnd.Next(1, 10 - player.Ships.ElementAt(s).Length);
                    coordinates.Column = rnd.Next(1, 10 - player.Ships.ElementAt(s).Length);
                }
                while (grid.CoordPositions[coordinates.Column, coordinates.Row] != 0);


                for (int i = 0; i < player.Ships.ElementAt(s).Length; i++)
                {
                    grid.CoordPositions[coordinates.Column + i, coordinates.Row] = s;
                }
            }
        }
        void AttackLoop(Map grid, Player player)
        {
            Console.WriteLine("Enter coordinates to Attack");

            Console.WriteLine("Cordinate X:");

            var xInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cordinate Y:");

            var yInput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            Console.Write("Attack: ");
            Console.WriteLine(Attack(grid, xInput, yInput, player));
        }

        public virtual string SetupMap()
        {
            GameMap playerMap = new GameMap();
            GameMap computerMap = new GameMap();

            playerMap.Map = new Map(GridSize, GridSize)
            {
                CoordPositions = new int[GridSize, GridSize]
            };

            computerMap.Map = new Map(GridSize, GridSize)
            {
                CoordPositions = new int[GridSize, GridSize]
            };

            DrawShips(playerMap.Map, Player);
            DrawShips(computerMap.Map, Computer);
            do
            {
                Console.WriteLine();

                Console.WriteLine("Computer Ships!");
                playerMap.DrawMap(GridSize, playerMap.Map);

                Console.WriteLine("Your Ships!");
                computerMap.DrawMap(GridSize, computerMap.Map);

                //PLAYER ATTACK
                AttackLoop(playerMap.Map, Player);
                Console.WriteLine();

                //COMPUTER ATTACK
                Console.Write("Computer Attack: ");
                Console.WriteLine(Attack(computerMap.Map, rnd.Next(1, 10), rnd.Next(1, 10), Computer));


            } while (!Player.IsWinner);

            return "Winner";
        }

    }
}
