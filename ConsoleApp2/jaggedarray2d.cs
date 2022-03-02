using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class jaggedarray2d
    {
        public static void Main()
        {  
            int[][,] jaggedarray2d = new int[4][,] {new int[, ] {{1, 3}, {5, 7}},
                                    new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                    new int[, ] {{7, 8}, {3, 1}, {0, 6}},
                                    new int[, ] {{11, 22}, {99, 88}, {0, 9}}};
            for (int i = 0; i < jaggedarray2d.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < jaggedarray2d[i].GetLength(x); j++)
                {             
                    for (int k = 0; k < jaggedarray2d[j].Rank; k++)
                        Console.Write("Jagged_Array[" + i + "][" + j + ", " + k + "]: "
                                                    + jaggedarray2d[i][j, k] + " ");
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
    

