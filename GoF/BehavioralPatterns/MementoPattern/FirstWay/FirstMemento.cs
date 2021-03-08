using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern.FirstWay
{
    class FirstMemento
    {
        public string Value { get;}
        public FirstMemento(string value)
        {
            Value = value;
        }
    }
}
