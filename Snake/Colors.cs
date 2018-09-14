using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Colors
    {
        public static void GrayLetters()
        {
            ConsoleColor barwa = ConsoleColor.DarkGray;
            Console.ForegroundColor = barwa;
        }
        public static void RedLetters()
        {
            ConsoleColor kolor = ConsoleColor.Red;
            Console.ForegroundColor = kolor;
        }
        public static void GreenLetters()
        {
            ConsoleColor kolor = ConsoleColor.Green;
            Console.ForegroundColor = kolor;
        }
        public static void BlueLetters()
        {
            ConsoleColor kolor = ConsoleColor.Blue;
            Console.ForegroundColor = kolor;
        }
        public static void PurppleLetters()
        {
            ConsoleColor kolor = ConsoleColor.Magenta;
            Console.ForegroundColor = kolor;
        }
        
    }
}
