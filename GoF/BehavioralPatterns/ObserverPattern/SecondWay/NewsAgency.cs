using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.SecondWay
{
    class NewsAgency : ISecondObserver
    {
        public Guid Id { get; set; }
        public NewsAgency()
        {
            Id = Guid.NewGuid();
        }

        public void Update(int value)
        {
            Console.WriteLine($"News agency get {value}");
        }
    }
}
