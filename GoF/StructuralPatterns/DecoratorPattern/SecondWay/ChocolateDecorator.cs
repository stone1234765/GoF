using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.SecondWay
{
    class ChocolateDecorator : IDecorator
    {
        public ICoffee Coffee { get; set; }
        public ChocolateDecorator(ICoffee coffee)
        {
            Coffee = coffee;
        }
        public decimal Price { get => Coffee.Price + 7; set => Coffee.Price = value; }
        public List<string> Ingredients
        {
            get
            {
                var ingredients = Coffee.Ingredients.Select(item => (string)item.Clone()).ToList();
                ingredients.Add("Chocolate");
                return ingredients;
            }
            set => Coffee.Ingredients = value;
        }

    }
}
