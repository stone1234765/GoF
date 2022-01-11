using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCompositeFiles
{
    class Leaf : IComponent
    {
        public string Name { get; set; }
        public IComponent Component { get; set; }
        private decimal price = 0;
        public decimal Price
        {
            get => price;
            set => price = value;
        }
        public Leaf(decimal price, string name)
        {
            this.price = price;
            Name = name;
        }
        public bool WriteIsCostBigger(decimal order)
        {
            if (Price < order)
            {
                if (Component != null)
                {
                    return Component.WriteIsCostBigger(order);
                }
                Console.WriteLine("No Component");
                return false;
            }
            Console.WriteLine($"{Name} is cost bigger");
            return true;
        }
    }
}
