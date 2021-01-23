using AbstractFactoryPattern.Models.Chairs;
using AbstractFactoryPattern.Models.Interfaces;

namespace AbstractFactoryPattern
{
    public class BFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new BChair { Legs = 2 };
        }
    }
}
