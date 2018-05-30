using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassActivity_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IHouse> Compt = new List<IHouse>();
            IHouse house = new House(40000);
            HardWoodFloor hwf = new HardWoodFloor();
            hwf.Price = 15000;
            house.AddComponent(Compt, hwf);
            Console.WriteLine("**********After adding 1st Component*************");
            Console.WriteLine("Total Price: " + house.Price);
            MapleKitchen mk = new MapleKitchen();
            mk.Price = 10000;
            house.AddComponent(Compt, mk);
            Console.WriteLine("**********After adding 2nd Component*************");
            Console.WriteLine("Total Price: " + house.Price);
            ColdCeller cc = new ColdCeller();
            cc.Price = 1200;
            house.AddComponent(Compt, cc);
            Console.WriteLine("**********After adding 3rd Component*************");
            Console.WriteLine("Total Price: "+house.Price);
            Console.Read();
        }
    }
}
