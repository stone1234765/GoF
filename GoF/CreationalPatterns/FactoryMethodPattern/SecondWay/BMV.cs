using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethodPattern.SecondWay
{
    class BMV
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public double MaxSpeed { get; set; }
        public BMV(string model, decimal price, double maxSpeed)
        {
            Model = model;
            Price = price;
            MaxSpeed = maxSpeed;
            Console.WriteLine(model);
            Console.WriteLine(price);
            Console.WriteLine(maxSpeed);
        }
        public BMV()
        {
            Console.WriteLine("empty");
        }
    }
}
