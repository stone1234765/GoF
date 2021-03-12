using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.SecondWay
{
    class Espresso : ICoffee
    {
        private decimal price { get; set; }
        private List<string> ingredients { get; set; }
        public decimal Price { get => price; set => price = value; }
        public List<string> Ingredients { get => ingredients; set => ingredients = value; }
        public Espresso()
        {
            price = 30;
            ingredients = new List<string>() { "Water", "Coffee" };
        }
    }
}
