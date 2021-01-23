using AbstractFactoryPattern.Models.Interfaces;
using System;

namespace AbstractFactoryPattern.Models.Chairs
{
    public class BChair : IChair
    {
        public int Legs { get; set; }

        public void HasLegs()
        {
            Console.WriteLine($"BChair has {Legs} legs");
        }

        public void SitOn()
        {
            Console.WriteLine("You sat on BChair");
        }
    }
}
