using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dictionary
    { 
        static public void Main()
        { 
            Dictionary<int, string> My_dict1 =
                           new Dictionary<int, string>();

            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "IBM");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();
            Dictionary<string, string> My_dict2 =
                    new Dictionary<string, string>(){
                                  {"a.1", "Dog"},
                                  {"a.2", "Cat"},
                                {"a.3", "Pig"} };

            foreach (KeyValuePair<string, string> ele2 in My_dict2)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }
          
                //stack
                Stack myStack = new Stack();
                myStack.Push("1st Element");
                myStack.Push("2nd Element");
                myStack.Push("3rd Element");
                myStack.Push("4th Element");
                myStack.Push("5th Element");
                myStack.Push("6th Element");
                Console.Write("Total number of elements in the Stack are : ");

                Console.WriteLine(myStack.Count);
                Console.WriteLine("Element at the top is : " + myStack.Peek());
                Console.WriteLine("Element at the top is : " + myStack.Peek());
                Console.Write("Total number of elements in the Stack are : ");

                Console.WriteLine(myStack.Count);


            //queue
            Queue my_queue = new Queue();
            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("srq123");
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }



            //hashtable
            Hashtable ht = new Hashtable();

            ht.Add("001", "pav");
            ht.Add("002", "Reshma");
            ht.Add("003", "John");
            ht.Add("004", "Manas");
            ht.Add("005", "sri");
            ht.Add("006", "Main");
            ht.Add("007", "Rikky");

            if (ht.ContainsValue("sri"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "sri");
            }
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }


            //Bitarray
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);

            byte[] a = { 60 };
            byte[] b = { 13 };
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);
            Console.WriteLine("Bit array ba1: 60");

            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0, -6} ", ba1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Bit array ba2: 13");

            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0, -6} ", ba2[i]);
            }
            Console.WriteLine();
            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);

            //content of ba3
            Console.WriteLine("Bit array ba3 after AND operation: 12");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();
            ba3 = ba1.Or(ba2);
            Console.WriteLine("Bit array ba3 after OR operation: 61");

            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
    


        


