using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Prize
    {
        public int walue { get; private set; }
        public Point position = new Point();

        public Prize()
        {
            Random Generator = new Random();
            this.walue = Generator.Next(0,5);
            position.x = Generator.Next(Area.minColumn + 1, Area.maxColumn-2);
            position.y = Generator.Next(Area.minRow + 1, Area.maxRow-1);
        }
        public void ViewPrize()
        {
            ConsoleColor Color = Console.ForegroundColor;
            Console.SetCursorPosition(position.x, position.y);
            if (this.walue == 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(this.walue);
            Console.ForegroundColor = Color;
        }
        public void ClearPrize()
        {
            Console.SetCursorPosition(position.x,position.y);
            Console.Write(" ");
        }
    }
}
