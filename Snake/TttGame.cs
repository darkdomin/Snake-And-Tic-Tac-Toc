using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class TttGame
    {
        bool win = false;
        bool pressed = true;
        int licznik = 1;
        int WinCounting = 0;
        int WinCounting2 = 0;
        public void NewGame()
        {
            Console.Clear();

            Colors.RedLetters();
            Person.EnterName(ref Person.NamePersonOne);
            Console.Clear();

            Person.EnterName(ref Person.NamePersonTwo);
            Console.Clear();
            ConsoleColor gray = ConsoleColor.Gray;
            Console.ForegroundColor = gray;
            Area.DrawBoard();

            Person.CalculatePositions(Person.NamePersonOne, Area.minColumn + 14, Area.minRow + 7);
            Colors.RedLetters();
            Person.WriteName(Person.NamePersonOne);
            CountWin(WinCounting, 14);

            Person.CalculatePositions(Person.NamePersonTwo, Area.minColumn + 85, Area.minRow + 7);
            Colors.GreenLetters();
            Person.WriteName(Person.NamePersonTwo);
            CountWin(WinCounting, 85);

            PlayGame();
        }
        public void PlayGame()
        {
            Person.MovePlayer(licznik);
            while (true)
            {
                ConsoleKeyInfo znak = Console.ReadKey();
                if (pressed)
                {
                    switch (znak.Key)
                    {
                        case ConsoleKey.D1:
                            if (Area.table[0, 0] == 'X' || Area.table[0, 0] == 'O')
                            {
                                pressed = true;

                            }
                            else if (Area.table[0, 0] == '1')
                            {

                                Area.table[0, 0] = 'X';
                                pressed = false;
                                licznik++;

                            }
                            break;
                        case ConsoleKey.D2:
                            if (Area.table[0, 1] == 'X' || Area.table[0, 1] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[0, 1] == '2')
                            {
                                Area.table[0, 1] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D3:
                            if (Area.table[0, 2] == 'X' || Area.table[0, 2] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[0, 2] == '3')
                            {
                                Area.table[0, 2] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D4:
                            if (Area.table[1, 0] == 'X' || Area.table[1, 0] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[1, 0] == '4')
                            {
                                Area.table[1, 0] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D5:
                            if (Area.table[1, 1] == 'X' || Area.table[1, 1] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[1, 1] == '5')
                            {
                                Area.table[1, 1] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D6:
                            if (Area.table[1, 2] == 'X' || Area.table[1, 2] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[1, 2] == '6')
                            {
                                Area.table[1, 2] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D7:
                            if (Area.table[2, 0] == 'X' || Area.table[2, 0] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[2, 0] == '7')
                            {
                                Area.table[2, 0] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D8:
                            if (Area.table[2, 1] == 'X' || Area.table[2, 1] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[2, 1] == '8')
                            {
                                Area.table[2, 1] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D9:
                            if (Area.table[2, 2] == 'X' || Area.table[2, 2] == 'O')
                            {
                                pressed = true;
                            }
                            else if (Area.table[2, 2] == '9')
                            {
                                Area.table[2, 2] = 'X';
                                pressed = false;
                                licznik++;
                            }
                            break;
                        default:
                            System.Windows.Forms.MessageBox.Show("Można wpisywać tylko cyfry!");
                            break;
                    }
                }
                else
                {
                    switch (znak.Key)
                    {
                        case ConsoleKey.D1:
                            if (Area.table[0, 0] == 'X' || Area.table[0, 0] == 'O')
                            {
                                pressed = false;

                            }
                            else if (Area.table[0, 0] == '1')
                            {
                                Area.table[0, 0] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D2:
                            if (Area.table[0, 1] == 'X' || Area.table[0, 1] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[0, 1] == '2')
                            {
                                Area.table[0, 1] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D3:
                            if (Area.table[0, 2] == 'X' || Area.table[0, 2] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[0, 2] == '3')
                            {
                                Area.table[0, 2] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D4:
                            if (Area.table[1, 0] == 'X' || Area.table[1, 0] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[1, 0] == '4')
                            {
                                Area.table[1, 0] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D5:
                            if (Area.table[1, 1] == 'X' || Area.table[1, 1] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[1, 1] == '5')
                            {
                                Area.table[1, 1] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D6:
                            if (Area.table[1, 2] == 'X' || Area.table[1, 2] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[1, 2] == '6')
                            {
                                Area.table[1, 2] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D7:
                            if (Area.table[2, 0] == 'X' || Area.table[2, 0] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[2, 0] == '7')
                            {
                                Area.table[2, 0] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D8:
                            if (Area.table[2, 1] == 'X' || Area.table[2, 1] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[2, 1] == '8')
                            {
                                Area.table[2, 1] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        case ConsoleKey.D9:
                            if (Area.table[2, 2] == 'X' || Area.table[2, 2] == 'O')
                            {
                                pressed = false;
                            }
                            else if (Area.table[2, 2] == '9')
                            {
                                Area.table[2, 2] = 'O';
                                pressed = true;
                                licznik++;
                            }
                            break;
                        default:
                            System.Windows.Forms.MessageBox.Show("Można wpisywać tylko cyfry!");
                            break;
                    }
                }
                Console.Clear();
                Person.MovePlayer(licznik);
                Person.CalculatePositions(Person.NamePersonOne, Area.minColumn + 14, Area.minRow + 7);
                Colors.RedLetters();
                Person.WriteName(Person.NamePersonOne);
                CountWin(WinCounting, 14);
                Person.CalculatePositions(Person.NamePersonTwo, Area.minColumn + 85, Area.minRow + 7);

                Colors.GreenLetters();
                Person.WriteName(Person.NamePersonTwo);
                CountWin(WinCounting, 85);
                Area.DrawBoard();
                Win();
            }
        }

        public void Win()
        {
            //sprawdzenie w poziomie
            if ((Area.table[0, 0] == Area.table[0, 1]) && (Area.table[0, 1] == Area.table[0, 2])) win = true;
            if ((Area.table[1, 0] == Area.table[1, 1]) && (Area.table[1, 1] == Area.table[1, 2])) win = true;
            if ((Area.table[2, 0] == Area.table[2, 1]) && (Area.table[2, 1] == Area.table[2, 2])) win = true;
            //sprawdzenie w pionie
            if ((Area.table[0, 0] == Area.table[1, 0]) && (Area.table[1, 0] == Area.table[2, 0])) win = true;
            if ((Area.table[0, 1] == Area.table[1, 1]) && (Area.table[1, 1] == Area.table[2, 1])) win = true;
            if ((Area.table[0, 2] == Area.table[1, 2]) && (Area.table[1, 2] == Area.table[2, 2])) win = true;
            //sprawdzenie po skosie
            if ((Area.table[0, 0] == Area.table[1, 1]) && (Area.table[1, 1] == Area.table[2, 2])) win = true;
            if ((Area.table[0, 2] == Area.table[1, 1]) && (Area.table[1, 1] == Area.table[2, 0])) win = true;

            if (win)
            {
                Colors.GrayLetters();
                Person.CalculatePositions("Wygrywa !!!", 30);
                Console.WriteLine("Wygrywa !!!");

                if (!pressed)
                {
                    WinCounting++;
                    Person.CalculatePositions(">>> " + Person.NamePersonOne + " <<<", 32);
                    Colors.RedLetters();
                    Console.WriteLine(">>> " + Person.NamePersonOne + " <<<");
                    CountWin(WinCounting, 14);
                    CountWin(WinCounting, 85);

                }
                else
                {
                    WinCounting++;
                    Person.CalculatePositions(">>> " + Person.NamePersonTwo + " <<<", 32);
                    Colors.GreenLetters();
                    Console.WriteLine(">>> " + Person.NamePersonTwo + " <<<");
                    CountWin(WinCounting, 14);
                    CountWin(WinCounting, 85);
                }
                FinalMenu();
            }
            else if (Area.table[0, 0] != '1' && Area.table[0, 1] != '2' && Area.table[0, 2] != '3' && Area.table[1, 0] != '4' && Area.table[1, 1] != '5' && Area.table[1, 2] != '6'
               && Area.table[2, 0] != '7' && Area.table[2, 1] != '8' && Area.table[2, 2] != '9' && !win)
            {
                Colors.GrayLetters();
                Person.CalculatePositions("Remis", 30);

                Console.WriteLine("Remis");
                FinalMenu();
            }
        }

        public void FinalMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.CursorVisible = false;
            Person.CalculatePositions("2 - Nowa Gra tych samych uczestników", 2);
            Console.WriteLine("1 - Nowa Gra");
            Person.CalculatePositions("2 - Nowa Gra tych samych uczestników", 4);
            Console.WriteLine("2 - Nowa Gra tych samych uczestników");
            Person.CalculatePositions("2 - Nowa Gra tych samych uczestników", 6);
            Console.WriteLine("3 - Wyjście");
            Console.ForegroundColor = ConsoleColor.Black;
            ConsoleKeyInfo znak = Console.ReadKey();

            if (znak.Key != ConsoleKey.D1 && znak.Key != ConsoleKey.D2 && znak.Key != ConsoleKey.Escape && znak.Key != ConsoleKey.D3)
            {

                FinalMenu();
            }
            else
            {
                switch (znak.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Area.table = new char[,]
                        {
                            {'1','2','3'},
                            {'4','5','6'},
                            {'7','8','9'},
                        };
                        win = false;
                        pressed = true;
                        Person.publicCounter = 0;
                        licznik = 1;
                        Person.MovePlayer(licznik);
                        WinCounting = 0;
                        WinCounting = 0;
                        NewGame();

                        break;

                    case ConsoleKey.D2:
                        Colors.GrayLetters();
                        Console.Clear();
                        Area.table = new char[,]
                         {
                            {'1','2','3'},
                            {'4','5','6'},
                            {'7','8','9'},
                         };
                        win = false;
                        Person.publicCounter = 0;
                        Area.DrawBoard();
                        Person.CalculatePositions(Person.NamePersonOne, Area.minColumn + 14, Area.minRow + 7);
                        Colors.RedLetters();
                        Person.WriteName(Person.NamePersonOne);
                        Person.CalculatePositions(Person.NamePersonTwo, Area.minColumn + 85, Area.minRow + 7);
                        Colors.GreenLetters();
                        Person.WriteName(Person.NamePersonTwo);
                        CountWin(WinCounting, 14);
                        CountWin(WinCounting, 85);
                        PlayGame();
                        break;
                    case ConsoleKey.D3:
                        System.Windows.Forms.MessageBox.Show("Dzięki za grę :)");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public void CountWin(int win, int x)
        {
            Person.CalculatePositions("Wygranych:", Area.minColumn + x, Area.minRow + 16);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Wygranych:");
            Person.CalculatePositions(win.ToString(), Area.minColumn + x, Area.minRow + 18);
            Console.WriteLine(win);
        }
    }
}
