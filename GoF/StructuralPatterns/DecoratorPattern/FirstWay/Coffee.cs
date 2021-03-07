using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.FirstWay
{
    abstract class Coffee
    {
        public abstract decimal Price { get; set; }
        public abstract List<string> Ingredients { get; set; }
    }
}
