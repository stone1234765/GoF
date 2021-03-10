using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.FirstWay
{
    interface IFirstObserver
    {
        void Inform(IAutoNews autoNews);
    }
}
