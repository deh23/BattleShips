using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleShipsConsole
{
   public class Ship
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public ShipType ShipType { get; set; }
        public int Hits { get; set; }
        public bool IsSunk
        {
            get
            {
                if (Hits >= Length)
                {
                    return true;
                }
                return false;

            }
            set => value = IsSunk;
        }
    }
}
