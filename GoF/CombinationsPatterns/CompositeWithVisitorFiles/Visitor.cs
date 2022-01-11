using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithVisitorFiles
{
    class Visitor : IVisitor
    {
        public void Visit(IComponent component)
        {
            Console.WriteLine(component.Price + ": component price");
        }
        public void Visit(Composite composite)
        {
            Console.WriteLine(composite.Price + ": composite price");
            composite.Components.ForEach(c => c.Accept(this));
        }
        public void Visit(Leaf leaf)
        {
            Console.WriteLine(leaf.Price + ": leaf price");
        }
    }
}
