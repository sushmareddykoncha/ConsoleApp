using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Looping
    {
       static void Main(string[] args)
        {
            //loping//
                Console.WriteLine("Calculator");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Substract");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divide");
                Console.WriteLine("Enter choice(1-4): ");
                int ch = Int32.Parse(Console.ReadLine());
                int a, b, c;
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter A,B:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("Sum = {0}", c);
                        break;
                    case 2:
                        Console.Write("Enter A,B:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine("Difference = {0}", c);
                        break;
                    case 3:
                        Console.Write("Enter A,B:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine("Product = {0}", c);
                        break;
                    case 4:
                        Console.Write("Enter A,B:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a / b;
                        Console.WriteLine("divison = {0}", c);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                


            //calculate the sum of n natural numbers

            int i, sum = 0, n;
            Console.WriteLine("enter the Nth numbers");
            n = int.Parse(Console.ReadLine());
            for(i=0; i<n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("sum of n numbers:" + sum);
            Console.ReadLine();
        }
    }
 }           

        
    

      

