using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern.SecondWay
{
    interface IMemento
    {
        Point[] Points { get; }
        string Color { get; }
    }
}
