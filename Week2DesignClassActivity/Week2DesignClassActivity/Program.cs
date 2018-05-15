using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2DesignClassActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeManager.LoadShapes();
            Shape s1, s2, s3;
            s1 = PrototypeManager.GetShape("C");
            s2 = PrototypeManager.GetShape("R");
            s3 = PrototypeManager.GetShape("S");
            Console.WriteLine("----------With Default values----------");
            Console.WriteLine("Area of Circle: " + s1.CalculateArea());
            Console.WriteLine("Perimeter of Circle: " + s1.CalculatePerimeter());
            Console.WriteLine("Area of Rectangle: " + s2.CalculateArea());
            Console.WriteLine("Perimeter of Rectangle: " + s2.CalculatePerimeter());
            Console.WriteLine("Area of Square: " + s3.CalculateArea());
            Console.WriteLine("Perimeter of Square: " + s3.CalculatePerimeter());

            Console.WriteLine("----------With user values----------");
            
            Console.WriteLine("Area of Circle: " + s1.CalculateArea());
            Console.WriteLine("Perimeter of Circle: " + s1.CalculatePerimeter());
            Console.WriteLine("Area of Rectangle: " + s2.CalculateArea());
            Console.WriteLine("Perimeter of Rectangle: " + s2.CalculatePerimeter());
            Console.WriteLine("Area of Square: " + s3.CalculateArea());
            Console.WriteLine("Perimeter of Square: " + s3.CalculatePerimeter());
            Console.Read();
        }
    }
}
