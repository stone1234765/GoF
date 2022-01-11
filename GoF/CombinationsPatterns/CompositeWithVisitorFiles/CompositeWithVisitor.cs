using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithVisitorFiles
{
    class CompositeWithVisitor
    {
        public void Run()
        {
            Console.WriteLine("CompositeWithVisitor");
            var visitor = new Visitor();
            IComponent apple = new Leaf(20, "apple");
            IComponent mause = new Leaf(50, "mause");
            IComponent smallBox = new Composite(new List<IComponent>() { apple }) { Name = "smallBox" };
            IComponent mediumBox = new Composite(new List<IComponent>() { smallBox }) { Name = "mediumBox" };
            IComponent bigBox = new Composite(new List<IComponent>() { mediumBox, mause }) { Name = "bigBox" };
            apple.Accept(visitor);
            mause.Accept(visitor);
            smallBox.Accept(visitor);
            mediumBox.Accept(visitor);
            bigBox.Accept(visitor);
            Console.WriteLine();
        }
    }
}
