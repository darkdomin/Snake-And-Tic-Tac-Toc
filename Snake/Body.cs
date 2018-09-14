using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Body
    {
        private static LinkedList<Point> bodySnake = new LinkedList<Point>();
        public static Course whereTurn;
        public static void CreateBody()
        {
            for (int i = 1; i < 10; i++)
            {
                bodySnake.AddFirst(new Point(i, Area.minRow + 6));
            }
            whereTurn = Course.right;
            DrawSnake();
        }
        public static void DrawPoint(Point pkt)
        {
            Console.SetCursorPosition(pkt.x, pkt.y);
            Console.Write("*");
        }
        public static void DrawSnake()
        {
            foreach (Point pkt in bodySnake)
            {
                DrawPoint(pkt);
            }
        }
        public static void ClearPoint(Point pkt)
        {
            Console.SetCursorPosition(pkt.x, pkt.y);
            Console.Write(" ");
        }
        public static void ClearSnake()
        {
            foreach (Point pkt in bodySnake)
            {
                ClearPoint(pkt);
            }
            bodySnake.Clear();
        }
        public static void MoveHead(ref int wPionie, ref int wPoziomie)
        {
            if (whereTurn == Course.right)
                wPoziomie = 1;
            else if (whereTurn == Course.left)
                wPoziomie = -1;
            if (whereTurn == Course.up)
                wPionie = -1;
            else if (whereTurn == Course.down)
                wPionie = 1;
        }
        public static void MakeMove()
        {
            int przesunWPionie = 0, przesunWPoziomie = 0;
            ClearPoint(bodySnake.Last.Value);
            bodySnake.RemoveLast();
            MoveHead(ref przesunWPionie, ref przesunWPoziomie);
            Point pkt = new Point();
            pkt.y = bodySnake.First.Value.y + przesunWPionie;
            pkt.x = bodySnake.First.Value.x + przesunWPoziomie;

            bodySnake.AddFirst(pkt);
            DrawPoint(pkt);
        }
        public static bool SlideSnake()
        {
            bool moveAllowed = true;
            if ((whereTurn == Course.right && bodySnake.First.Value.x >= Area.maxColumn - 2) ||
              (whereTurn == Course.left && bodySnake.First.Value.x <= Area.minColumn + 1) ||
              (whereTurn == Course.up && bodySnake.First.Value.y <= Area.minRow + 1) ||
              (whereTurn == Course.down && bodySnake.First.Value.y >= Area.maxRow - 1))
            {
                moveAllowed = false;
            }
            else
            {
                MakeMove();
            }
            return moveAllowed;
        }
        public static void UstalPrzesuniecieDlaOgona(ref int WPionie, ref int WPoziomie)
        {
            MoveHead(ref WPionie, ref WPoziomie);
            WPoziomie = WPoziomie * (-1);
            WPionie = WPionie * (-1);
        }

        public static void Snakestretching()
        {
            int przesunWPionie = 0, przesunWPoziomie = 0;
            Point pkt = new Point();
            UstalPrzesuniecieDlaOgona(ref przesunWPionie, ref przesunWPoziomie);
            pkt.y = bodySnake.First.Value.y + przesunWPionie;
            pkt.x = bodySnake.First.Value.x + przesunWPoziomie;
            bodySnake.AddLast(pkt);
            DrawPoint(pkt);
        }
        public static bool CzyJestTu(Point pktNagrody)
        {
            bool score = false;
            foreach (Point pkt in bodySnake)
            {
                if (pkt.x == pktNagrody.x &&
                   pkt.y == pktNagrody.y)
                {
                    score = true;
                    break;
                }
            }
            return score;
        }
        internal static bool Suicide()
        {
            bool result = false;
            bool ifFIirstPoint = true;
            foreach (Point pkt in bodySnake)
            {
                if (!ifFIirstPoint)
                {
                    if (bodySnake.First.Value.x == pkt.x &&
                     bodySnake.First.Value.y == pkt.y)
                    {
                        result = true;
                        break;
                    }
                }
               ifFIirstPoint = false;
            }
            return result;
        }
    }
}
