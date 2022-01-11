using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCompositeFiles
{
    class Apple : IComponent
    {
        public string Name { get; set; }
        public IComponent Component { get; set; }
        private decimal price = 0;
        public decimal Price
        {
            get => price;
            set => price = value;
        }
        public Apple(decimal price)
        {
            this.price = price;
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
            Console.WriteLine("Apple is cost bigger");
            return true;
        }
    }
}
