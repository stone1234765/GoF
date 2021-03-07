using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.PrototypePattern.FirstWay
{
    abstract class Auto
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public double MaxSpeed { get; set; }
        public Auto(Guid id, decimal price, double maxSpeed)
        {
            Id = id;
            Price = price;
            MaxSpeed = maxSpeed;
        }
        public abstract Auto Clone();
    }
}
