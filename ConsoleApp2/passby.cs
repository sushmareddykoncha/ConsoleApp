using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class passby
    {
        static void Main(string[] args)
        {
            int x = 7;
            Console.WriteLine("Value Before Calling: {0}", x);
            MultiplyPassbyValue(x);
            Console.WriteLine("Value After MultiplyPassbyValue: {0}", x);
            MultiplyPassbyRef(ref x);
            Console.WriteLine("Value After MultiplyPassbyRef: {0}", x);

            int y;
            MultiplyPassbyOut(out y);
            Console.WriteLine("Value of Y after MultiplyPassbyOut is: {0}", y);
            Console.ReadLine();
        }
        public static void MultiplyPassbyValue(int a)
        {
            a = a * a;
            Console.WriteLine("Value Inside MultiplyPassbyValue: {0}", a);
        }

        public static void MultiplyPassbyRef(ref int a)
        {
            a = a * a;
            Console.WriteLine("Value Inside MultiplyPassbyRef: {0}", a);
        }

        public static void MultiplyPassbyOut(out int y)
        {
            y = 30;
            y = y * y;
        }
    }
}
