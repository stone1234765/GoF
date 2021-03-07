using GoF.BehavioralPatterns.IteratorPattern.FirstWay;
using GoF.BehavioralPatterns.IteratorPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.IteratorPattern
{
    class Iterator
    {
        public void Run()
        {
            Console.WriteLine("Iterator");
            //First way
            Console.WriteLine("First way");
            var elements = new StringIterator(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"});
            Iterate(elements);


            //Second way
            Console.WriteLine("Second way");
            var week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();
        }
        private void Iterate(IStringIterator iterator)
        {
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
            Console.WriteLine();
        }
    }
}
