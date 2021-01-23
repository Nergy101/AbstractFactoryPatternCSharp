using AbstractFactoryPattern.Models.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    public static class Program
    {
        static void Main()
        {
            var startup = new Startup();
            IFurnitureFactory factory;

            // determine what factory to use from startup settings
            if (startup.Configuration.FactoryType == "A")
                factory = new AFurnitureFactory();
            else if (startup.Configuration.FactoryType == "B")
                factory = new BFurnitureFactory();
            else
                throw new Exception("FactoryType setting wasn't configured properly");

            DescribeChair(factory);
        }

        /// <summary>
        /// Simulates the client code only knowing it gets a Factory.
        /// Probably some service/handler that gets injected with the IFurnitureFactory
        /// but does not know what implementation types
        /// </summary>
        private static void DescribeChair(IFurnitureFactory factory)
        {
            IChair chair = factory.CreateChair();
            chair.SitOn();
            chair.HasLegs();
        }
    }
}
