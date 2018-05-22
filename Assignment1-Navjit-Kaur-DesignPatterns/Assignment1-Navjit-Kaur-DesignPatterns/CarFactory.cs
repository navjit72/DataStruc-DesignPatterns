using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Navjit_Kaur_DesignPatterns
{
    public abstract class CarFactory
    {
        public abstract Car GetCar(string car);
    }

    public class HondaFactory : CarFactory
    {
        public override Car GetCar(string Car)
        {
            switch (Car)
            {
                case "F":
                    return new Fit();
                case "C":
                    return new Civic();
                case "A":
                    return new Accord();
                default:
                    throw new ApplicationException(string.Format("'{0}' cannot be created", Car));
            }
        }
    }

    public class ToyotaFactory : CarFactory
    {
        public override Car GetCar(string Car)
        {
            switch (Car)
            {
                case "Y":
                    return new Yaris();
                case "O":
                    return new Corolla();
                case "M":
                    return new Camry();
                default:
                    throw new ApplicationException(string.Format("'{0}' cannot be created", Car));
            }
        }
    }
}
