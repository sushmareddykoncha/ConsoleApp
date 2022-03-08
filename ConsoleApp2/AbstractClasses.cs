using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AbstractClasses
    {
        abstract class Car
        {
            public abstract void carType();
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        class Audi : Car
        {
            public override void carType()
            {
                Console.WriteLine("The car type: Sedan");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Audi car = new Audi();
                car.carType();
                car.sleep();
            }
        }
    }
}
