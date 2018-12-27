using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TableGame
    {
        public string[,] MatTable()
        {
            string[,] mat = new string[5, 5];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    if (i % 2 == 0)
                    {
                        if (y % 2 == 0)
                        {

                            Console.Write(" ");

                        }
                        else
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        Console.Write("=");
                    }

                }
                Console.WriteLine();
            }
            return mat;
        }

      
    }
}
