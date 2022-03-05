using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Struct
    {
        struct Employee
        {
            public string id;
            public string name;
            public int salary;
        };

        public static void Main(string[] args)
        {
            Employee emp1;
            emp1.id = "000BIM";
            emp1.name = "Koncha Sushma";
            emp1.salary = 30000;

            Console.WriteLine("Employee id: {0}", emp1.id);
            Console.WriteLine("Employee name: {0}", emp1.name);
            Console.WriteLine("Employee salary: {0}", emp1.salary);

            Console.ReadKey();
        }
    }
}
