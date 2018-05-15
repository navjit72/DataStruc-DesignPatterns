using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2DesignClassActivity
{
    [Serializable]
    public abstract class IPrototype<T>
    {
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }
    }

    [Serializable]
    public class PrototypeManager : IPrototype<Shape>
    {
        private static Dictionary<string, Shape> protoTypes=new Dictionary<string, Shape>();

        public static void LoadShapes()
        {
            protoTypes.Add("C", new Circle());
            protoTypes.Add("R", new Rectangle());
            protoTypes.Add("S", new Square());
        }

        public static Shape GetShape(String shapeId)
        {
            Shape shapeCopy = protoTypes[shapeId];
            return (Shape)shapeCopy.Clone();
        }
    }

    public abstract class Shape : IPrototype<Shape>
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 1;
            Type = "Circle";
        }
        public Circle(double radius)
        {
            Radius = radius;
            Type = "Circle";
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle()
        {
            Length = Width = 1;
            Type = "Rectangle";
        }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            Type = "Rectangle";
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

    public class Square : Rectangle
    {
        public Square()
        {
            Length = Width = 1;
            Type = "Square";
        }
        public Square(double side)
        {
            Length = Width = side;
            Type = "Square";
        }
    }
}
