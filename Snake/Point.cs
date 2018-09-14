using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
        public Point() {}
    }
}
