using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(array2D[0, 0]);
            Console.WriteLine(array2D[0, 1]);
            Console.WriteLine(array2D[1, 0]);
            Console.WriteLine(array2D[1, 1]);

            int[] array = new int[4];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
