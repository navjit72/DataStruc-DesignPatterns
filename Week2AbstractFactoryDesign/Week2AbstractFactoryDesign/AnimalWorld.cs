using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AbstractFactoryDesign
{
    class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;
        //private ContinentFactory factory;

        public AnimalWorld(ContinentFactory factory)
        {
           // this.factory = factory;
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
