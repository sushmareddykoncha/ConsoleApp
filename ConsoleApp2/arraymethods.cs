using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class arraymethods
    {
        public static void Main()
        {
            string[] topic;
            topic = new string[] {"Array, ", "String, ",
                              "Stack, ", "Queue, ",
                              "Exception, ", "Operators" };
            Console.WriteLine("Topic of C# before reverse:");
            Console.WriteLine();
            foreach (string ele in topic)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine();
            Array.Reverse(topic);
            Console.WriteLine("Topic of C# after reverse:");
            Console.WriteLine();
            foreach (string val in topic)
            {
                Console.WriteLine(val + " ");
            }
           
            Array.Sort(topic);
            Console.WriteLine("Topic of C# after reverse:");
            Console.WriteLine();
            foreach (string val in topic)
            {
                Console.WriteLine(val + " ");
                Console.ReadLine();
            }
        }
    }
        

}

    
      


