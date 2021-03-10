using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.ThirdWay
{
    internal class Unsubscriber<News> : IDisposable
    {
        private List<IObserver<News>> observers { get; set; }
        private IObserver<News> observer { get; set; }
        public Unsubscriber(List<IObserver<News>> observers, IObserver<News> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}
