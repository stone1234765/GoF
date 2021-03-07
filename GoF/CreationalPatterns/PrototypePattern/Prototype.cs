using GoF.CreationalPatterns.PrototypePattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.PrototypePattern
{
    class Prototype
    {
        public void Run()
        {

            Console.WriteLine("Prototype");
            //First way
            Console.WriteLine("First way");
            var autos = new List<Auto>();
            autos.Add(new BMW(Guid.NewGuid(), 100000, 300));
            autos.Add(new Audi(Guid.NewGuid(), 150000, 320));
            autos.Add(new Mers(Guid.NewGuid(), 200000, 350));
            foreach (var auto in autos)
            {
                Console.WriteLine("Firs Data:");
                Console.WriteLine($"Original! Id: {auto.Id}, Price: {auto.Price}, MaxSpeed: {auto.MaxSpeed}");
                var clone = auto.Clone();
                Console.WriteLine($"Clone! Id: {clone.Id}, Price: {clone.Price}, MaxSpeed: {clone.MaxSpeed}");
                clone.Price = clone.Price * (decimal)0.85;
                Console.WriteLine("Second Data:");
                Console.WriteLine($"Original! Id: {auto.Id}, Price: {auto.Price}, MaxSpeed: {auto.MaxSpeed}");
                Console.WriteLine($"Clone! Id: {clone.Id}, Price: {clone.Price}, MaxSpeed: {clone.MaxSpeed}");
            }

            Console.WriteLine();
        }
    }
}
