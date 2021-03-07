using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.IteratorPattern.FirstWay
{
    interface IStringIterator
    {
        string Next();
        bool HasNext();
    }
}
