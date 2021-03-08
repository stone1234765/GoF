using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern.SecondWay
{
    class PainterMemento : IMemento
    {
        public Point[] Points { get; }
        public string Color { get; }
        public PainterMemento(Point[] points, string color)
        {
            Points = points;
            Color = color;
        }
    }
}
