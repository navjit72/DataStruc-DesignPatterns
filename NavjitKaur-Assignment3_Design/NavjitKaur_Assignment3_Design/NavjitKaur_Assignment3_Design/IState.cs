using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavjitKaur_Assignment3_Design
{
    public interface IState
    {
        double Result(Calculator calculator,double num1, double num2);
        string GetOp();
    }

    public class Add : IState
    {
        public double Result(Calculator calculator,double number1,double number2)
        {
            calculator.State = new Subtract();
            return number1 + number2;
        }

        public string GetOp()
        {
            return "Add";
        }
    }

    public class Subtract : IState
    {
        public double Result(Calculator calculator,double number1, double number2)
        {
            calculator.State = new Multiply();
            if (number1 > number2)
                return number1 - number2;
            else
                return number2 - number1;
        }
        public string GetOp()
        {
            return "Subtract";
        }
    }

    public class Multiply : IState
    {
        public double Result(Calculator calculator,double number1, double number2)
        {
            calculator.State = new Divide();
            return number1 * number2;
        }
        public string GetOp()
        {
            return "Multiply";
        }
    }

    public class Divide : IState
    {
        public double Result(Calculator calculator,double number1, double number2)
        {
            calculator.State = new Add();
            if (number2 != 0)
                return number1 / number2;
            else
                throw new DivideByZeroException("Second number can not be zero");
        }
        public string GetOp()
        {
            return "Divide";
        }
    }

}
