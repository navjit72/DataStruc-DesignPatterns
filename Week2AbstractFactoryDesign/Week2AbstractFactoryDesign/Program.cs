using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AbstractFactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory america = new AmericaFactory();
            AnimalWorld world = new AnimalWorld(america);
            world.RunFoodChain();

            ContinentFactory africa = new AfricaFactory();
            world = new AnimalWorld(africa);
            world.RunFoodChain();
        }
    }
}
