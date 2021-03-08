using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.SecondWay
{
    class Report : IVisitable
    {
        public string Title { get; set; }
        public string[] Illustrations { get; set; }
        public string[] Paragraphs { get; set; }
        public int[] Template { get; set; }
        public Report(string title, string[] illustrations, string[] paragraphs, int[] template)
        {
            Title = title;
            Illustrations = illustrations;
            Paragraphs = paragraphs;
            Template = template;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
