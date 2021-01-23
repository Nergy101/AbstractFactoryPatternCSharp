﻿using AbstractFactoryPattern.Models.Interfaces;
using System;

namespace AbstractFactoryPattern.Models.Chairs
{
    public class AChair : IChair
    {
        public int Legs { get; set; }

        public void HasLegs()
        {
            Console.WriteLine($"AChair has {Legs} legs");
        }

        public void SitOn()
        {
            Console.WriteLine("You sat on AChair");
        }
    }
}
