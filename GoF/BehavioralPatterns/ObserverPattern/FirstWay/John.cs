using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.FirstWay
{
    class John : IFirstObserver
    {
        public void Inform(IAutoNews autoNews)
        {
            Console.WriteLine($"John get {autoNews.News}");
        }
    }
}
