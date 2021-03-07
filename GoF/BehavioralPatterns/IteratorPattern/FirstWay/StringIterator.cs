using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.IteratorPattern.FirstWay
{
    class StringIterator : IStringIterator
    {
        private string[] Elements { get; set; }
        public int Index = 0;
        public StringIterator(string[] elements)
        {
            Elements = elements;
        }
        public string Next()
        {
            return Elements[Index++];
        }
        public bool HasNext()
        {
            return Index < Elements.Length;
        }
    }
}
