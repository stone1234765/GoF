using GoF.CombinationsPatterns.ChainOfResponsibilityWithCompositeFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCompositeFiles
{
    class ChainOfResponsibilityWithComposite
    {
        public void Run()
        {
            Console.WriteLine("ChainOfResponsibilityWithComposite");
            var apple = new Leaf(20, "apple");
            var mause = new Leaf(50, "mause");
            var smallBox = new Composite(new List<IComponent>() { apple }) { Name = "smallBox" };
            var mediumBox = new Composite(new List<IComponent>() { smallBox }) { Name = "mediumBox" };
            var bigBox = new Composite(new List<IComponent>() { mediumBox, mause }) { Name = "bigBox" };

            var order = 10;
            apple.WriteIsCostBigger(order);
            mause.WriteIsCostBigger(order);
            Console.WriteLine();

            order = 30;
            apple.WriteIsCostBigger(order);
            mause.WriteIsCostBigger(order);
            Console.WriteLine();

            order = 60;
            apple.WriteIsCostBigger(order);
            mause.WriteIsCostBigger(order);
            Console.WriteLine();
        }
    }
}
