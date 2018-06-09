using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavjitKaur_Assignment3_Design
{
    public interface IState
    {
        double Result();
    }

    public class Add : IState
    {
        private double number1;
        private double number2;
        public Add(double num1,double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public double Result()
        {
            return number1 + number2;
        }
    }

    public class Subtract : IState
    {
        private double number1;
        private double number2;
        public Subtract(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public double Result()
        {
            if (number1 > number2)
                return number1 - number2;
            else
                return number2 - number1;
        }
    }

    public class Multiply : IState
    {
        private double number1;
        private double number2;
        public Multiply(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public double Result()
        {
            return number1 * number2;
        }
    }

    public class Divide : IState
    {
        private double number1;
        private double number2;
        public Divide(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public double Result()
        {
            if (number2 != 0)
                return number1 / number2;
            else
                throw new DivideByZeroException("Second number can not be zero");
        }
    }

}
