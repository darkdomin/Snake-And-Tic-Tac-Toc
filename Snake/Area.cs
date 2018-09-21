using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Area
    {
        public static readonly int minRow = 0;
        public static readonly int minColumn = 0;
        public static readonly int maxRow = 35;
        public static readonly int maxColumn = 100;
        public static char[,] table = new char[,]
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},
        };

        public static void DrawArea()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string space = string.Empty;
            Console.SetCursorPosition(minColumn, minRow);
            Console.Write(space.PadLeft(maxColumn));
            Console.SetCursorPosition(minColumn, maxRow);
            Console.Write(space.PadLeft(maxColumn));

            for (int i = 1; i < maxRow; i++)
            {
                Console.SetCursorPosition(minColumn, i);
                Console.Write(" ");
                Console.SetCursorPosition(maxColumn - 1, i);
                Console.Write(" ");
            }
            WritePoints(0);
            Console.SetWindowPosition(0, 0);
        }

        public static void WritePoints(int points)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(minColumn + 1, maxRow);
            Console.Write("Wynik: {0}", points);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void DrawBoard()
        {
            Console.SetWindowPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            string space = string.Empty;
            Console.SetCursorPosition(30, 9);
            Console.Write(space.PadLeft(38));
            Console.SetCursorPosition(30, 27);
            Console.Write(space.PadLeft(38));

            for (int i = 9; i < 28; i++)
            {
                Console.SetCursorPosition(30, i);
                Console.Write("  ");
                Console.SetCursorPosition(68, i);
                Console.Write("  ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            int column = Area.minColumn + 36;
            int row = Area.minRow + 12;
            string txt = "             ";
            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.SetCursorPosition(column, row);
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == 'X')
                    {
                        Colors.RedLetters();
                    }
                    else if (table[i, j] == 'O')
                    {
                        Colors.GreenLetters();
                    }
                    else { Colors.GrayLetters(); }
                    if (j == 2 || j == 5 || j == 8) Console.Write(table[i, j]);
                    else Console.Write(table[i, j] + txt);
                }
                row += 6;
            }
        }
    }
}

