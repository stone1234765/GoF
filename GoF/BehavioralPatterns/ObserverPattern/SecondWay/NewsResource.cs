using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.SecondWay
{
    class NewsResource : IObservable
    {
        private List<ISecondObserver> Observers { get; set; }
        private int value { get; set; }
        public int Value 
        { 
            get => value;
            set
            {
                this.value = value;
                NotifyObservers();
            }
        }

        public NewsResource()
        {
            value = 0;
            Observers = new List<ISecondObserver>();
        }

        public void Add(ISecondObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(ISecondObserver observer)
        {
            Observers = Observers.Where(observer => observer.Id != observer.Id).ToList();
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Value);
            }
        }
    }
}
