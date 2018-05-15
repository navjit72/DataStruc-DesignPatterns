using System;
using System.Collections.Generic;
using System.Text;

namespace LabActivity1.Business
{
    interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    public class RightTriangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public RightTriangle(double b, double height)
        {
            Base = b;
            Height = height;
        }
        public double GetArea()
        {
            return (Base*Height)/ 2;
        }

        public double GetPerimeter()
        {
            return Base + Height + Math.Sqrt(Base * Base + Height * Height);
        }
    }


}
