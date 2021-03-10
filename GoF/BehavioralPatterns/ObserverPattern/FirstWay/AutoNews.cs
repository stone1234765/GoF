using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.FirstWay
{
    class AutoNews : IAutoNews
    {
        public List<IFirstObserver> Observers { get; set; }
        private string news { get; set; }
        public string News 
        {
            get => news;
            set
            {
                news = value;
                NotifyAll();
            }
        }
        public AutoNews()
        {
            Observers = new List<IFirstObserver>();
            News = "";
        }
        private void NotifyAll()
        {
            foreach (var observer in Observers)
            {
                observer.Inform(this);
            }
        }
    }
}
