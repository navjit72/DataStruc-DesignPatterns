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
      
        public Calculator(IState state)
        {
            State = state;
        }

        public double Calculate(double number1, double number2)
        {
            return State.Result(this,number1,number2);
        }

        public string Operation()
        {
            return State.GetOp();
        }
    }
}
