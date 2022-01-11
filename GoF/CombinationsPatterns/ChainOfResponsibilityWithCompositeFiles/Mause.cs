using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCompositeFiles
{
    class Mause : IComponent
    {
        public string Name { get; set; }
        public IComponent Component { get; set; }
        private decimal price = 0;
        public decimal Price 
        {
            get => price;
            set => price = value;
        }
        public Mause(decimal price)
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
            Console.WriteLine("Mause is cost bigger");
            return true;
        }
    }
}
