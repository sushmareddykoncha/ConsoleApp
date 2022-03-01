using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        
        {   
            //conditional statements//
            int a,b,c;
            Console.WriteLine("Enter the values");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("a is greater");
                }
                else
                {
                    Console.WriteLine("c is greater");
                }
            }
            else if(b>c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }
            //swap 2 numbers 
            int num1, num2;
            Console.WriteLine("Enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("num1=" + num1);
            Console.WriteLine("num2=" + num2);
           

            //get emp details and display them//
            Console.WriteLine("Enter the employee details");
            String empid,name;
            int age;
            float salary;
            empid = Console.ReadLine();
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            salary = float.Parse(Console.ReadLine());
            Console.WriteLine("empid=" + empid);
            Console.WriteLine("name=" + name);
            Console.WriteLine("age=" + age);
            Console.WriteLine("salary=" + salary);
            Console.ReadLine();

            
        }
    }
}
