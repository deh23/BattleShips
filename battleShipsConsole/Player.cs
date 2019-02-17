using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShipsConsole
{
    public class Player
    {
        public string Name { get; set; }
        public List<Ship> Ships { get; set; }
        public bool IsWinner
        {
            get
            {
                return Ships.All(x => x.IsSunk);
            }
            set => value = IsWinner;
        }

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>
            {
                new BattleShip(),
                new Destroyer(),
                new Destroyer()
            };
        }
    }
}