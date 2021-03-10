using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.SecondWay
{
    interface ISecondObserver
    {
        Guid Id { get; set; }
        void Update(int value);
    }
}
