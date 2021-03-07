using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.CompositePattern.FirstWay
{
    interface IComponent
    {
        Guid Id { get; set; }
        decimal Price { get; set; }
        List<string> Options { get; set; }
    }
}
