using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.SecondWay
{
    interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
