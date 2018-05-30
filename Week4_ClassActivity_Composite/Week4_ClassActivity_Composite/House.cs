using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassActivity_Composite
{
    public interface IHouse
    {
        double Price { get; set; }
        void AddComponent(List<IHouse> Components,IHouse Component);
        double DisplayPrice();
    }
    public class House : IHouse
    {
        public double Price { get; set; }
        public double BasePrice { get; set; }
        public House(double basePrice)
        {
            BasePrice = Price = basePrice;
        }
        public void AddComponent(List<IHouse> Components,IHouse Component)
        {
            Components.Add(Component);
            Price += Component.Price;
        }
        public double DisplayPrice()
        {
            return Price;
        }
    }
    public class HardWoodFloor : IHouse
    {
        public double Price { get; set; }
        public void AddComponent(List<IHouse> Components,IHouse Component)
        {
            throw new CustomException("Not Applicable here");
        }
        public double DisplayPrice()
        {
            return Price;
        }
    }
    public class MapleKitchen : IHouse
    {
        public double Price { get; set; }
        public void AddComponent(List<IHouse> Components,IHouse Component)
        {
            throw new CustomException("Not Applicable here");
        }
        public double DisplayPrice()
        {
            return Price;
        }
    }
    public class ColdCeller : IHouse
    {
        public double Price { get; set; }
        public void AddComponent(List<IHouse> Components,IHouse Component)
        {
            throw new CustomException("Not Applicable here");
        }
        public double DisplayPrice()
        {
            return Price;
        }
    }
}
