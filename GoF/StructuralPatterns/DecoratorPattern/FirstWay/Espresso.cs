using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.FirstWay
{
    class Espresso : Coffee
    {
        public override decimal Price {
            get => 30;
            set => Price = value;
        }
        public override List<string> Ingredients { 
            get => new List<string>() { "Water", "Coffee" } ;
            set => Ingredients = value;
        }
    }
}
