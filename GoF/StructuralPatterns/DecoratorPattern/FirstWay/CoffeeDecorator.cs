using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.FirstWay
{
    abstract class CoffeeDecorator : Coffee
    {
        private Coffee Coffee { get; set; }
        public override decimal Price {
            get => Coffee.Price;
            set => Coffee.Price = value;
        }
        public override List<string> Ingredients
        {
            get => Coffee.Ingredients;
            set => Coffee.Ingredients = value;
        }
        public CoffeeDecorator(Coffee coffee)
        {
            Coffee = coffee;
        }
    }
}
