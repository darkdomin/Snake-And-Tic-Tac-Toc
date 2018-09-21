using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Menu
    {
       // public void AuxiliaryFunctionDefiningX(string name)
        //{
        //    int polNazwy = name.Length / 2;
        //    int polSzerokosci = Area.maxColumn / 2;
        //    int x = polSzerokosci - polNazwy;
        //    Console.WriteLine(x);
        //}

        public static void Start()
        {
            Console.SetBufferSize(Area.maxColumn, Area.maxRow+3 );
            Console.SetWindowSize(Area.maxColumn, Area.maxRow+1 );
            Console.Title = "GRY KONSOLOWE";
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(Area.minColumn + 44, Area.minRow + 4);
                Console.Write("GRY KONSOLOWE");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(Area.minColumn + 40, Area.minRow + 14);
                Console.Write("1 - Snake");
                Console.SetCursorPosition(Area.minColumn + 40, Area.minRow + 18);
                Console.Write("2 - Kółko i Krzyżyk");
                Console.SetCursorPosition(Area.minColumn + 40, Area.minRow + 22);
               
                Console.Write("3 - Wyjdź");
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.Title = "S N A K E";
                        Game.NewGame();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.Title = "K Ó Ł K O   I   K R Z Y Ż Y K";
                        TttGame nowy = new TttGame();
                          nowy.NewGame();
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D3:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
