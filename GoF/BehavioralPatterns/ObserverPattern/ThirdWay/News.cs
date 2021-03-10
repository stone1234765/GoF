using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ObserverPattern.ThirdWay
{
    class News
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public News(Guid id, string value)
        {
            Id = id;
            Value = value;
        }
        public News(string value)
        {
            Id = Guid.NewGuid();
            Value = value;
        }
    }
}
