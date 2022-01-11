using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithVisitorFiles
{
    interface IComponent
    {
        string Name { get; set; }
        decimal Price { get; set; }
        void Accept(IVisitor visitor);
    }
}
