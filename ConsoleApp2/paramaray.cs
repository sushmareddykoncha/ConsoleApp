using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class paramaray
    {
        static int add(params int[] allnumber)
        {
            int sum = 0;
            foreach (int n in allnumber)
            {
                sum = sum + n;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum;
            // passing three parameters
            sum = add(1, 2, 3);
            Console.WriteLine("Sum of 1,2,3 is:\t{0}", sum);
            Console.ReadLine();
        }
    }
}
    

