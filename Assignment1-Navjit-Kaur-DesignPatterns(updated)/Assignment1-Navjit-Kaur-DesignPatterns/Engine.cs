using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Navjit_Kaur_DesignPatterns
{
    public abstract class EngineFactory
    {
        public double Capacity { get; set; }
        public int Cylinders { get; set; }
        public abstract Engine CreateEngine(int code);
    }
    public class Engine : EngineFactory
    {
        public Engine()
        {
            Cylinders = 4;
        }
        public override Engine CreateEngine(int code)
        {
            switch(code)
            {
                case 15:
                    return new Eng15();
                case 18:
                    return new Eng18();
                case 20:
                    return new Eng20();
                case 25:
                    return new Eng25();
                default:
                    throw new ApplicationException(string.Format("'{0}' invalid value", code));
            }
        }
    }
    public class Eng18 : Engine
    {
        public Eng18()
        {
            Capacity = 1.8;
        }
    }
    public class Eng15 : Engine
    {
        public Eng15()
        {
            Capacity = 1.5;
        }
    }
    public class Eng20 : Engine
    {
        public Eng20()
        {
            Capacity = 2.0;
        }
    }
    public class Eng25 : Engine
    {
        public Eng25()
        {
            Capacity = 2.5;
        }
    }
}
