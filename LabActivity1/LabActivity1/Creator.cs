using LabActivity1.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabActivity1
{
    class Creator
    {
        public IShape FactoryMethod(string shapeType)
        {
            IShape shape = null;
            if(shapeType.Equals("C"))
            {
                shape = new Circle(5);
            }
            else if(shapeType.Equals("R"))
            {
                shape = new Rectangle(10, 12);
            }
            else if(shapeType.Equals("T"))
            {
                shape = new RightTriangle(5, 3);
            }
            else
            {
                Console.WriteLine("Wrong shape type");
            }
            return shape;
        }
    }
}
