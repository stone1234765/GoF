using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.DecoratorPattern.SecondWay
{
    interface IDecorator : ICoffee
    {
        ICoffee Coffee { get; set; }
    }
}
