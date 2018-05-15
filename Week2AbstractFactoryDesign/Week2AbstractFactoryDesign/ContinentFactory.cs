using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AbstractFactoryDesign
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildbeast();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

}
