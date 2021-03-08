using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.FirstWay
{
    abstract class Visitor
    {
        public abstract void ExportVisitor(Auto auto);
    }
}
