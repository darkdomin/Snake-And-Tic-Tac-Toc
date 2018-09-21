using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Person
    {
        public static String NamePersonOne;
        public static String NamePersonTwo;
        static ConsoleColor Gray = ConsoleColor.Gray;
        public static int publicCounter;

       // public static string NameOne { get; internal set; }

        public static void CheckLength(string name)
        {
            if (name.Length < 2 || name.Length > 25)
            {
                System.Windows.Forms.MessageBox.Show("Nazwa zawodnika musi być dłuższa niż 2 znaki i krótsza niż 10!");
                Console.Clear();
            }
        }

        public static void SetCursorAndWriteName(ref string name)
        {
            string kolejnosc1 = "pierwszego";
            string kolejnosc2 = "drugiego";

            Console.ForegroundColor = Gray;
          
            if (publicCounter == 0)
            {
                Console.SetCursorPosition(Area.minColumn + 2, Area.minRow + 7);
                Console.WriteLine("Podaj imię gracza " + kolejnosc1 + ": ");
                Colors.RedLetters();
                Console.SetCursorPosition(Area.minColumn + 2, Area.minRow + 9);
                name = Console.ReadLine();
            }
            else
            {
                Console.SetCursorPosition(Area.minColumn + 2, Area.minRow + 7);
                Console.WriteLine("Podaj imię gracza " + kolejnosc2 + ": ");
                Colors.GreenLetters();
                Console.SetCursorPosition(Area.minColumn + 2, Area.minRow + 9);
                name = Console.ReadLine();
            }
            Console.CursorVisible = true;
        }
                
        public static void EnterName(ref string name)
        {
            do
            {
                SetCursorAndWriteName(ref name);
                CheckLength(name);
            } while (name.Length < 2 || name.Length > 25);
            publicCounter++;
        }

        public static void WriteName( string name)
        {
            Console.Write(name);
        }

        public static void CalculatePositions(string nazwa,int x, int y)
        {
                int position = x - nazwa.Length / 2;
                Console.SetCursorPosition(position, y);
        }

        public static void CalculatePositions(string name,int wiersz)
        {
            int name1 = name.Length / 2;
            int middle = Area.maxColumn / 2;
            int position = middle - name1;
            Console.SetCursorPosition(position, wiersz);
        }

        public static void MovePlayer(int x)
        {
            Console.CursorVisible = false;

            if (x % 2 != 0)
            {

                Console.ForegroundColor = Gray;
                Console.SetCursorPosition(9, 5);
                Console.Write("Ruch Gracza: ");
                x++;
            }
            else
            {

                Console.ForegroundColor = Gray;
                Console.SetCursorPosition(79, 5);
                Console.Write("Ruch Gracza: ");
                x++;
            }
        }
    } 
}
