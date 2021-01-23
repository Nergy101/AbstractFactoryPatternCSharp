using AbstractFactoryPattern.Models.Interfaces;

namespace AbstractFactoryPattern
{
    public interface IFurnitureFactory
    {
        public IChair CreateChair();
    }
}
