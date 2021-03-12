using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.SecondWay
{
    class WhippedMilkDecorator : IDecorator
    {
        public ICoffee Coffee { get; set; }
        public WhippedMilkDecorator(ICoffee coffee)
        {
            Coffee = coffee;
        }
        public decimal Price { get => Coffee.Price + 15; set => Coffee.Price = value; }

        public List<string> Ingredients
        {
            get
            {
                var ingredients = Coffee.Ingredients.Select(item => (string)item.Clone()).ToList();
                ingredients.Add("Whipped milk");
                return ingredients;
            }
            set => Coffee.Ingredients = value;
        }
    }
}
