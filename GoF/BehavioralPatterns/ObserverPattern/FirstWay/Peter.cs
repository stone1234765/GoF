using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.FirstWay
{
    class Peter : IFirstObserver
    {
        public void Inform(IAutoNews autoNews)
        {
            Console.WriteLine($"Peter get {autoNews.News}");
        }
    }
}
