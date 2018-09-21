using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    static class Game
    {
        static bool gameOn = true;
        static DateTime start = DateTime.Now;
        static Prize prize = new Prize();
        static int score = 0;

        public static void NewGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            gameOn = true;
            score = 0;
            Area.DrawArea();
            Body.CreateBody();
            prize.ViewPrize();
            Graj();
        }

        public static void Graj()
        {
            while (gameOn)
            {
                LoadKey();
                if (!gameOn) break;
                NewPrize();
                SnakeAte();
                if (!gameOn) break;
                SnakeGoing();
                if (!gameOn) break;
                SnakeAtePrize();
                Thread.Sleep(100);
            }
        }

        private static void SnakeAte()
        {
            if (Body.Suicide())
            {
                GameOver();
            }
        }

        private static void SnakeAtePrize()
        {
            if (Body.IsheHere(prize.position))
            {
                if (prize.walue == 0)
                {
                    Body.ClearSnake();
                    Body.CreateBody();
                    score = 0;
                }
                else
                {
                    score += prize.walue;
                    Body.Snakestretching();
                }
                Area.WritePoints(score);
                prize = new Prize();
                prize.ViewPrize();
            }
        }

        public static void NewPrize()
        {
            if (start <= DateTime.Now.Subtract(TimeSpan.FromSeconds(10)))
            {
                prize.ClearPrize();
                start = DateTime.Now;
                prize = new Prize();
                prize.ViewPrize();
            }
        }

        private static void SnakeGoing()
        {
            if (!Body.SlideSnake())
            {
                GameOver();
            }
        }

        private static void GameOver()
        {
            gameOn = false;
            ConsoleColor Color = Console.ForegroundColor;
            Console.SetCursorPosition(Area.minColumn + 34, Area.minRow + 15);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Game Over");
            Console.ForegroundColor = Color;
            Console.ReadKey();
            Body.ClearSnake();
        }

        private static void LoadKey()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo klawisz = Console.ReadKey(true);
                if (klawisz.Key == ConsoleKey.LeftArrow &&
                    Body.whereTurn != Course.right)
                {
                    Body.whereTurn = Course.left;
                }
                if (klawisz.Key == ConsoleKey.RightArrow &&
                   Body.whereTurn != Course.left)
                {
                    Body.whereTurn = Course.right;
                }
                if (klawisz.Key == ConsoleKey.UpArrow &&
                   Body.whereTurn != Course.down)
                {
                    Body.whereTurn = Course.up;
                }
                if (klawisz.Key == ConsoleKey.DownArrow &&
                   Body.whereTurn != Course.up)
                {
                    Body.whereTurn = Course.down;
                }
                if (klawisz.Key == ConsoleKey.Escape)
                {
                    GameOver();
                }
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
            }
        }
    }
}
