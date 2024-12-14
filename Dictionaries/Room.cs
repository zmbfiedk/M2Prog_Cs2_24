using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class Room
    {
        internal int x, y;
        internal string[] level;

        Room St = new Room(0, 0,[
            "xxxxx",
            "x...x",
            "x...x",
            "x...x",
            "xxxxx"
            ]);

        internal string GetRoomLocationKey()
        {
            return $"{x},{y}";
        }

        internal Room(int x, int y, string[] level)
        {
            this.x = x; 
            this.y = y;
            this.level = level;
        }
    }
}
