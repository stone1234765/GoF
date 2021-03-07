using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.FirstWay
{
    class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee)
            : base(coffee)
        {
        }

        public override decimal Price { 
            get => base.Price + 10; 
            set => base.Price = value;
        }
        public override List<string> Ingredients
        {
            get
            {
                var ingredients = base.Ingredients;
                ingredients.Add("Milk");
                return ingredients;
            }
            set
            {
                base.Ingredients = value;
            }
        }
    }
}
