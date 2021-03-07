using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.BuilderPattern.FirstWay
{
    class CarBuilder
    {
        public Car Car { get; set; }
        public CarBuilder()
        {
            Car = new Car();
        }
        public CarBuilder AddAutoPilot(bool autoPilot)
        {
            Console.WriteLine("Add auto pilot");
            Car.AutoPilot = autoPilot;
            return this;
        }
        public CarBuilder AddParktronic(bool autoPilot)
        {
            Console.WriteLine("Add parktronic");
            Car.Parktronic = autoPilot;
            return this;
        }
        public CarBuilder AddSignaling(bool autoPilot)
        {
            Console.WriteLine("Add signaling");
            Car.Signaling = autoPilot;
            return this;
        }
        public CarBuilder UpdateEngine(string engine)
        {
            Console.WriteLine("Update engine");
            Car.Engine = engine;
            return this;
        }
        public Car Build()
        {
            Console.WriteLine("Get car");
            return Car;
        }
    }
}
