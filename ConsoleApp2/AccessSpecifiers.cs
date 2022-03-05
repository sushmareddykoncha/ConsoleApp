using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AccessSpecifiers
    {
        class Rectangle
        {
            public double length;
            private double width;

            public void setWidth(double width)
            {
                this.width = width;
            }

            public double GetArea()
            {
                return length * width;
            }
            public void Display()
            {
                Console.WriteLine("Length: {0}", this.length);
                Console.WriteLine("Width: {0}", this.width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }

        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.length = 4.5;
                r.setWidth(3.5);
                r.Display();
                Console.ReadLine();
            }
        }
    }
}

    

