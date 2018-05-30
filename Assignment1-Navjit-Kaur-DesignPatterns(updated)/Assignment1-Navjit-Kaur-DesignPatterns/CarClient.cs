using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Navjit_Kaur_DesignPatterns
{
    public class CarClient
    {
        Car car;

        public CarClient(CarFactory factory, string type)
        {
            car = factory.GetCar(type);
        }

        public string DisplayCarFeatures()
        {
            return car.Display();
        }
    }
}
