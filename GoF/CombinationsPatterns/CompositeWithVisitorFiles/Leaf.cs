using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithVisitorFiles
{
    class Leaf : IComponent
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Leaf(decimal price, string name)
        {
            Price = price;
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
