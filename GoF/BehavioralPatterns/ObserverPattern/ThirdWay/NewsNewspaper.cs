using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.ThirdWay
{
    class NewsNewspaper : IObservable<News>
    {
        private List<IObserver<News>> Observers { get; set; }
        private List<News> News { get; set; }
        public NewsNewspaper()
        {
            Observers = new List<IObserver<News>>();
            News = new List<News>();
        }
        public IDisposable Subscribe(IObserver<News> observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
                SendPreviouslyNews(observer);
            }
            return new Unsubscriber<News>(Observers, observer);
        }
        private void SendPreviouslyNews(IObserver<News> observer)
        {
            foreach (var item in News)
            {
                observer.OnNext(item);
            }
        }
        public void AddNews(News news)
        {
            News.Add(news);
            foreach (var observer in Observers)
            {
                observer.OnNext(news);
            }
        }

        public void StopNotify()
        {
            foreach (var observer in Observers)
            {
                observer.OnCompleted();
            }
            Observers.Clear();
        }
    }
}
