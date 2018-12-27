using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ConsoleApplication1
{

    class Program
    {
        public static void text(int a, int b)
        {

            Console.SetCursorPosition(0, 12);
            Console.WriteLine("{0},{1}", a, b);

        }
        public string key { get; set; }


        static void Main(string[] args)
        {
            
            Player p1;
            Player p2;
            int checkWinOrEven = 0;
            Turn t = new Turn();
            TableGame tbl = new TableGame();



            Console.WriteLine("*******welcome to X-O game*******");
            Console.Write("enter first player name please: ");  string firstPlayer = Console.ReadLine();
            Console.Write("enter second player name please: "); string scondPlayer = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("{0} you are first! ", firstPlayer);
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            bool exitGame = true;
            while (exitGame)
            {
                int x = 0;
                int y = 0;
                string[,] mat = tbl.MatTable();
                Console.SetCursorPosition(x, y);
                p1 = new Player() { name = firstPlayer, sign = "X", row = 0 };
                p2 = new Player() { name = scondPlayer, sign = "O", row = 1 };
                ConsoleKeyInfo key = new ConsoleKeyInfo();
                checkWinOrEven = 0;
                bool keepPlay = true;
                while (keepPlay)
                {
                    key = Console.ReadKey();
                    Console.SetCursorPosition(x, y);
                    if ((key.Key == ConsoleKey.RightArrow) && (x < 4))
                    {
                        Console.SetCursorPosition(x = x + 2, y);
                        t.RetMat(mat);
                    }
                    if ((key.Key == ConsoleKey.LeftArrow) && (x != 0))
                    {
                        Console.SetCursorPosition(x = x - 2, y);
                        t.RetMat(mat);
                    }
                    if ((key.Key == ConsoleKey.UpArrow) && (y != 0))
                    {
                        Console.SetCursorPosition(x, y = y - 2);
                        t.RetMat(mat);
                    }
                    if ((key.Key == ConsoleKey.DownArrow) && (y < 4))
                    {
                        Console.SetCursorPosition(x, y = y + 2);
                        t.RetMat(mat);
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        
                        t.TurnNow(p1, p2, x, y, mat);
                        t.RetMat(mat);
                        checkWinOrEven = t.WiningOrEven(mat, p1, p2);
                    }
                    else
                    {
                        t.RetMat(mat);
                    }
                    Console.SetCursorPosition(x, y);
                    if ((checkWinOrEven == 1)||p1.row==9)
                    {
                        keepPlay = false;
                    }

                }
                
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("another round? click Yes/No");
                string answer = Console.ReadLine();

                if (answer == "no" || answer == "n")
                {
                    exitGame = false;
                }
                
                Console.Clear();


            }
            string mssg = " bye bye...";
            for (int i = 0; i < mssg.Length; i++)
            {
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black + i;
                Console.Write(mssg[i]);
            }
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine();
        }
    }
}

