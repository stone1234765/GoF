using GoF.BehavioralPatterns.ObserverPattern.FirstWay;
using GoF.BehavioralPatterns.ObserverPattern.SecondWay;
using GoF.BehavioralPatterns.ObserverPattern.ThirdWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern
{
    class Observer
    {
        public void Run()
        {
            Console.WriteLine("Observer");
            //First way
            Console.WriteLine("First way");
            var autoNews = new AutoNews();

            var john = new John();
            var peter = new Peter();

            autoNews.Observers.AddRange(new List<IFirstObserver>() { john, peter });
            autoNews.News = "New news";


            //Second way
            Console.WriteLine("Second way");
            var newsResource = new NewsResource();

            var newsAgency = new NewsAgency();
            var reporter = new Reporter();
            var blogger = new Blogger();

            newsResource.Add(newsAgency);
            newsResource.Add(reporter);
            newsResource.Add(blogger);

            newsResource.Value = 23;


            //Third way
            Console.WriteLine("Third way");
            var newsNewspaper = new NewsNewspaper();
            var kolya = new Kolya();
            newsNewspaper.AddNews(new News("First news"));
            newsNewspaper.AddNews(new News("Second news"));
            newsNewspaper.Subscribe(kolya);
            newsNewspaper.AddNews(new News("Third news"));
            newsNewspaper.AddNews(new News("Fourth news"));
            newsNewspaper.StopNotify();
            newsNewspaper.AddNews(new News("Fifth news"));

            Console.WriteLine();
        }
    }
}
