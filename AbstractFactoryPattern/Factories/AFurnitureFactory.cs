using AbstractFactoryPattern.Models.Chairs;
using AbstractFactoryPattern.Models.Interfaces;

namespace AbstractFactoryPattern
{
    public class AFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new AChair { Legs = 4 };
        }
    }
}
