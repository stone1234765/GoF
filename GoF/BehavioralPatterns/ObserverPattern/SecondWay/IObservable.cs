using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.SecondWay
{
    interface IObservable
    {
        void Add(ISecondObserver observer);
        void Remove(ISecondObserver observer);
        void NotifyObservers();
    }
}
