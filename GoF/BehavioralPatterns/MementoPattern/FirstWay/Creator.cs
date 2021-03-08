using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern.FirstWay
{
    class Creator
    {
        private string _value { get; set; }
        public Creator()
        {
        }
        public Creator(string value)
        {
            _value = value;
        }
        public FirstMemento Save()
        {
            return new FirstMemento(_value);
        }
        public void Restore(FirstMemento firstMemento)
        {
            _value = firstMemento.Value;
            Console.WriteLine(_value);
        }
    }
}
