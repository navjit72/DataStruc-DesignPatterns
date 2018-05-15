using LabActivity1.Business;
using System;

namespace LabActivity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            IShape s = c.FactoryMethod("C");
            s = c.FactoryMethod("R");
           
            Console.WriteLine("Area of circle = " + s.GetArea());
            Console.WriteLine("Area of rectangle = " + r.GetArea());
            Console.Read();
        }
    }
}
