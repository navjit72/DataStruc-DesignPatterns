using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Navjit_Kaur_DesignPatterns
{
    public interface Car
    {
        string Name();
        double Capacity();
        int Cylinder();
        double Price();
        string Display();
    }
    public class Yaris : Car
    {
        public double Capacity()
        {
            return 1.5;
        }

        public int Cylinder()
        {
            return 4;
        }

        public string Display()
        {
            return Name() + " has " + Capacity() + " liter " + Cylinder() + " cylinder engine and retail price of $" + Price() + "."; 
        }

        public string Name()
        {
            return "Yaris";
        }

        public double Price()
        {
            return 15490;
        }
    }
    public class Corolla : Car
    {
        public double Capacity()
        {
            return 1.8;
        }

        public int Cylinder()
        {
            return 4;
        }

        public string Name()
        {
            return "Corolla";
        }

        public double Price()
        {
            return 16790;
        }
        public string Display()
        {
            return Name() + " has " + Capacity() + " liter " + Cylinder() + " cylinder engine and retail price of $" + Price() + ".";
        }
    }
    public class Camry : Car
    {
        public double Capacity()
        {
            return 2.5;
        }

        public int Cylinder()
        {
            return 4;
        }

        public string Name()
        {
            return "Camry";
        }

        public double Price()
        {
            return 26590;
        }
        public string Display()
        {
            return Name() + " has " + Capacity() + " liter " + Cylinder() + " cylinder engine and retail price of $" + Price() + ".";
        }
    }
    public class Fit : Car
    {
        public double Capacity()
        {
            return 1.5;
        }

        public int Cylinder()
        {
            return 4;
        }

        public string Name()
        {
            return "Fit";
        }

        public double Price()
        {
            return 15190;
        }
        public string Display()
        {
            return Name() + " has " + Capacity() + " liter " + Cylinder() + " cylinder engine and retail price of $" + Price() + ".";
        }
    }
    public class Civic : Car
    {
        public double Capacity()
        {
            return 2.0;
        }

        public int Cylinder()
        {
            return 4;
        }

        public string Name()
        {
            return "Civic";
        }

        public double Price()
        {
            return 16790;
        }
        public string Display()
        {
            return Name() + " has " + Capacity() + " liter " + Cylinder() + " cylinder engine and retail price of $" + Price() + ".";
        }
    }
    public class Accord : Car
    {
        public double Capacity()
        {
            return 1.5;
        }

        public int Cylinder()
        {
            return 4;
        }

        public string Name()
        {
            return "Accord";
        }

        public double Price()
        {
            return 26590;
        }

        public string Display()
        {
            return Name() + " has " + Capacity() + " liter " + Cylinder() + " cylinder engine and retail price of $" + Price() + ".";
        }
    }
}
