using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Navjit_Kaur_DesignPatterns
{
    public abstract class Car
    {
        public EngineFactory EngFactory = new Engine();
        public Engine engine;
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract string Display();
    }
    public class Yaris : Car
    {
        public Yaris()
        {
            Name = "Yaris";
            Price = 15490;
            engine=EngFactory.CreateEngine(15);
        }

        public override string Display()
        {
            return Name + " has " + engine.Capacity + " liter " + engine.Cylinders + " cylinders engine and retail price of $" + Price + "."; 
        }
    }
    public class Corolla : Car
    {
        public Corolla()
        {
            Name = "Corolla";
            Price = 16790;
            engine = EngFactory.CreateEngine(18);
        }

        public override string Display()
        {
            return Name + " has " + engine.Capacity + " liter " + engine.Cylinders + " cylinders engine and retail price of $" + Price + ".";
        }
    }
    public class Camry : Car
    {
        public Camry()
        {
            Name = "Camry";
            Price = 26590;
            engine = EngFactory.CreateEngine(25);
        }

        public override string Display()
        {
            return Name + " has " + engine.Capacity + " liter " + engine.Cylinders + " cylinders engine and retail price of $" + Price + ".";
        }
    }
    public class Fit : Car
    {
        public Fit()
        {
            Name = "Fit";
            Price = 15190;
            engine = EngFactory.CreateEngine(15);
        }

        public override string Display()
        {
            return Name + " has " + engine.Capacity + " liter " + engine.Cylinders + " cylinders engine and retail price of $" + Price + ".";
        }
    }
    public class Civic : Car
    {
        public Civic()
        {
            Name = "Civic";
            Price = 16790;
            engine = EngFactory.CreateEngine(20);
        }

        public override string Display()
        {
            return Name + " has " + engine.Capacity + " liter " + engine.Cylinders + " cylinders engine and retail price of $" + Price + ".";
        }
    }
    public class Accord : Car
    {
        public Accord()
        {
            Name = "Accord";
            Price = 26590;
            engine = EngFactory.CreateEngine(15);
        }

        public override string Display()
        {
            return Name + " has " + engine.Capacity + " liter " + engine.Cylinders + " cylinders engine and retail price of $" + Price + ".";
        }
    }
}
