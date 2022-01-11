using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithVisitorFiles
{
    interface IVisitor
    {
        void Visit (IComponent component);
        void Visit(Composite component);
        void Visit(Leaf component);
    }
}
