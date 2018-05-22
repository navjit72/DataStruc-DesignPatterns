using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Navjit_Kaur_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory honda = new HondaFactory();
            CarClient hondaClient = new CarClient(honda, "F");

            Console.WriteLine("*******Honda********");
            Console.WriteLine(hondaClient.DisplayCarFeatures());

            CarFactory toyota = new ToyotaFactory();
            CarClient toyotaClient = new CarClient(toyota, "Y");

            Console.WriteLine("*******Toyota*******");
            Console.WriteLine(toyotaClient.DisplayCarFeatures());

            hondaClient = new CarClient(honda, "C");

            Console.WriteLine("*******Honda********");
            Console.WriteLine(hondaClient.DisplayCarFeatures());

            toyotaClient = new CarClient(toyota, "O");

            Console.WriteLine("*******Toyota*******");
            Console.WriteLine(toyotaClient.DisplayCarFeatures());

            hondaClient = new CarClient(honda, "A");

            Console.WriteLine("*******Honda********");
            Console.WriteLine(hondaClient.DisplayCarFeatures());

            toyotaClient = new CarClient(toyota, "M");

            Console.WriteLine("*******Toyota*******");
            Console.WriteLine(toyotaClient.DisplayCarFeatures());

            Console.ReadKey();
        }
    }
}
