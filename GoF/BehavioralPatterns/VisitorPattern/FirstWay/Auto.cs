using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.FirstWay
{
    abstract class Auto
    {
        public void Accept(Visitor visitor)
        {
            visitor.ExportVisitor(this);
        }
    }
}
