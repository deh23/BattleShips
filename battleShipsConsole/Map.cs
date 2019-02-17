using System;
using System.Collections.Generic;

namespace battleShipsConsole
{
    class Map
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public int[,] CoordPositions { get; set; }

        public Map(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public string Value;
    }
}
