using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class InterfaceExample
    {
        interface ICar
        {
            void carType();
        }

        class Audi : ICar
        {
            public void carType()
            {
                Console.WriteLine("The car Type is Sedan");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Audi car = new Audi();
                car.carType();
            }
        }
    }
}
