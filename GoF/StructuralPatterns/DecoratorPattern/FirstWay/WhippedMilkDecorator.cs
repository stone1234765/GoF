using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.FirstWay
{
    class WhippedMilkDecorator : CoffeeDecorator
    {
        public WhippedMilkDecorator(Coffee coffee)
            : base(coffee)
        {

        }

        public override decimal Price { 
            get => base.Price + 15; 
            set => base.Price = value; 
        }

        public override List<string> Ingredients {
            get {
                var ingredients = base.Ingredients;
                ingredients.Add("Whipped milk");
                return ingredients;
            } 
            set => base.Ingredients = value; 
        }
    }
}
