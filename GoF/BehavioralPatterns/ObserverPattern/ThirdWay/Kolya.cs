using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.ThirdWay
{
    class Kolya : IObserver<News>
    {
        private List<News> ReadNews { get; set; }
        private IDisposable cancellation;
        public Kolya()
        {
            ReadNews = new List<News>();
        }
        public void Subscribe(IObservable<News> observable)
        {
            cancellation = observable.Subscribe(this);
        }
        public void UnSubscribe()
        {
            cancellation.Dispose();
        }
        public void OnCompleted()
        {
            Console.WriteLine($"Your subscription has ended, you readed {ReadNews.Count} news");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(News value)
        {
            ReadNews.Add(value);
            Console.WriteLine($"Read new news with id - {value.Id} and value {value.Value}, read news count - {ReadNews.Count}");
        }
    }
}
