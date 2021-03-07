using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.FirstWay
{
    class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(Coffee coffee)
            :base(coffee)
        {

        }

        public override decimal Price { 
            get => base.Price + 7;
            set => base.Price = value;
        }
        public override List<string> Ingredients {
            get {
                var ingredients = base.Ingredients;
                ingredients.Add("Chocolate");
                return ingredients;
            }
            set => base.Ingredients = value; 
        }
    }
}
