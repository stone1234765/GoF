using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.SecondWay
{
    interface ICoffee
    {
        decimal Price { get; set; }
        List<string> Ingredients { get; set; }
    }
}
