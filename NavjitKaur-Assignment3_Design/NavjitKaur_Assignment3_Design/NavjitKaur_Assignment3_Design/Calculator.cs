using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavjitKaur_Assignment3_Design
{
    public class Calculator
    {
        public IState State { get; set; }

        public double Add(double num1,double num2)
        {
            State = new Add(num1,num2);
            return State.Result();
        }
        public double Sub(double num1, double num2)
        {
            State = new Subtract(num1, num2);
            return State.Result();
        }
        public double Mul(double num1, double num2)
        {
            State = new Multiply(num1, num2);
            return State.Result();
        }
        public double Div(double num1, double num2)
        {
            State = new Divide(num1, num2);
            return State.Result();
        }

    }
}
