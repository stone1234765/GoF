using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.SecondWay
{
    class Reporter : ISecondObserver
    {
        public Guid Id { get; set; }
        public Reporter()
        {
            Id = Guid.NewGuid();
        }

        public void Update(int value)
        {
            Console.WriteLine($"Reporter get {value}");
        }
    }
}
