using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Turn
    {
        
        public void GetDetailsAboutPlayer()
        {
            Player p = new Player();
            Console.WriteLine("now {0}'s turn", p.name);
        }

        Player p1 = new Player();
        Player p2 = new Player();
        public void TurnNow(Player p1, Player p2, int a, int b, string[,] mat)
        {
            if (p1.row % 2 == 0)
            {
                while (mat[a, b] == null)
                {
                    mat[a, b] = p1.sign;
                    p1.row++;
                    p2.row++;
                }


            }
            else if (p2.row % 2 == 0)
            {
                while (mat[a, b] == null)
                {
                    mat[a, b] = p2.sign;
                    p2.row++;
                    p1.row++;
                }
            }

        }

        public string[,] RetMat(string[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int k = 0; k < mat.GetLength(1); k++)
                {
                    Console.SetCursorPosition(i, k);
                    Console.Write(mat[i, k]);
                }
            }
            return mat;
        }

        public int WiningOrEven(string[,] mat, Player p1, Player p2)
        {
            if ((mat[0, 0] == p1.sign && mat[0, 2] == p1.sign && mat[0, 4] == p1.sign) ||
                (mat[2, 0] == p1.sign && mat[2, 2] == p1.sign && mat[2, 4] == p1.sign) ||
                (mat[4, 0] == p1.sign && mat[4, 2] == p1.sign && mat[4, 4] == p1.sign) ||
                (mat[0, 0] == p1.sign && mat[2, 2] == p1.sign && mat[4, 4] == p1.sign) ||
                (mat[4, 0] == p1.sign && mat[2, 2] == p1.sign && mat[0, 4] == p1.sign) ||
                (mat[0, 0] == p1.sign && mat[2, 0] == p1.sign && mat[4, 0] == p1.sign) ||
                (mat[0, 2] == p1.sign && mat[2, 2] == p1.sign && mat[4, 2] == p1.sign) ||
                (mat[0, 4] == p1.sign && mat[2, 4] == p1.sign && mat[4, 4] == p1.sign))
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("well done {0}! ", p1.name, Console.ForegroundColor = ConsoleColor.Yellow);
                Console.ForegroundColor = ConsoleColor.Gray;
                return 1;
            }

            else if ((mat[0, 0] == p2.sign && mat[0, 2] == p2.sign && mat[0, 4] == p2.sign) ||
                    (mat[2, 0] == p2.sign && mat[2, 2] == p2.sign && mat[2, 4] == p2.sign) ||
                    (mat[4, 0] == p2.sign && mat[4, 2] == p2.sign && mat[4, 4] == p2.sign) ||
                    (mat[0, 0] == p2.sign && mat[2, 2] == p2.sign && mat[4, 4] == p2.sign) ||
                    (mat[4, 0] == p2.sign && mat[2, 2] == p2.sign && mat[0, 4] == p2.sign) ||
                    (mat[0, 0] == p2.sign && mat[2, 0] == p2.sign && mat[4, 0] == p2.sign) ||
                    (mat[0, 2] == p2.sign && mat[2, 2] == p2.sign && mat[4, 2] == p2.sign) ||
                    (mat[0, 4] == p2.sign && mat[2, 4] == p2.sign && mat[4, 4] == p2.sign))
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("well done {0}!", p2.name, Console.ForegroundColor = ConsoleColor.Yellow);
                Console.ForegroundColor = ConsoleColor.Gray;
                return 1;
            }
            return 0;
        }
    }
}
