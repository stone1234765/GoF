using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.SecondWay
{
    class SpreadSheet : IVisitable
    {
        public string Title { get; set; }
        public string[] Structure { get; set; }
        public SpreadSheet(string title, string[] structure)
        {
            Title = title;
            Structure = structure;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
