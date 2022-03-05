using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class NullableTypes
    {
        static void Main(string[] args)
        {
            Nullable<int> a = null;
            Console.WriteLine(a.GetValueOrDefault());

            int? b = null;
            Console.WriteLine(b.GetValueOrDefault());

            int? c = 7;
            Console.WriteLine(c.GetValueOrDefault());

            Nullable<int> d = 77;
            Console.WriteLine(d.GetValueOrDefault());

        }
    }
}
