using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithIteratorFiles
{
    class CompositeWithIterator
    {
        public void Run()
        {
            Console.WriteLine("CompositeWithIterator");

            var apple = new Leaf(20, "apple");
            var mause = new Leaf(50, "mause");
            var smallBox = new Composite(new List<IComponent>() { apple, new Leaf(50, "mause1") }) { Name = "smallBox" };
            var mediumBox = new Composite(new List<IComponent>() {  new Leaf(50, "mause2"), smallBox, new Leaf(50, "mause2"), new Leaf(50, "mause3") }) { Name = "mediumBox" };
            var bigBox = new Composite(new List<IComponent>() { new Leaf(50, "mause4"), mediumBox, mause }) { Name = "bigBox" };
            foreach (var item in bigBox)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();
        }
    }
}
