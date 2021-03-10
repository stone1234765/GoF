using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.SecondWay
{
    class Blogger : ISecondObserver
    {
        public Guid Id { get; set; }
        public Blogger()
        {
            Id = Guid.NewGuid();
        }

        public void Update(int value)
        {
            Console.WriteLine($"Blogger get {value}");
        }
    }
}
