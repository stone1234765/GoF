using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.SecondWay
{
    interface IVisitor
    {
        void Visit(Report report);  
        void Visit(SpreadSheet spreadSheet);
    }
}
