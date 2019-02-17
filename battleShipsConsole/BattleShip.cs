using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShipsConsole
{
   public class BattleShip : Ship
    {
        public BattleShip()
        {
            Name = "BattleShip";
            Length = 5;
            ShipType = ShipType.BattleShip;
        }
    }

}
