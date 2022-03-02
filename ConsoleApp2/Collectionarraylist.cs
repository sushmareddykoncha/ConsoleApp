using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Collectionarraylist
    {
        public static void Main()
        {
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            arlist1.Remove(null);
            arlist1.Reverse();
            Console.WriteLine(arlist1.Count);
            arlist1.Clear();
            Console.WriteLine(arlist1.Count);

            LinkedList<String> linkedList = new LinkedList<String>();
            linkedList.AddFirst("First");
            linkedList.AddFirst("First 1");
            linkedList.AddLast("Last");
            linkedList.RemoveFirst();
            linkedList.Reverse();
            Console.WriteLine(linkedList.Count);
            linkedList.Clear();
            Console.WriteLine(linkedList.Count);


            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(4, null);
            sortedList.Add(10, "Ten");
            sortedList.Add(5, "Five");
            sortedList.Remove(1);

            foreach (var s in sortedList)
                Console.WriteLine("key: {0}, value: {1}", s.Key, s.Value);
            Console.ReadLine();
        }
    }


}
        

