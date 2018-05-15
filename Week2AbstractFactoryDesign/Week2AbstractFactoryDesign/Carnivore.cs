using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AbstractFactoryDesign
{
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eat " + h.GetType().Name);
        }
    }
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eat " + h.GetType().Name);
        }
    }
}
