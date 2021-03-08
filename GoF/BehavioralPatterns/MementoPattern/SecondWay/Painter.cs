using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern.SecondWay
{
    class Painter
    {
        private Point[] points { get; set; }
        private string color { get; set; }
        public Painter(string color)
        {
            this.color = color;
            points = new Point[0];
        }
        public string Description()
        {
            var stingBuilder = new StringBuilder();
            foreach (var point in points)
            {
                stingBuilder.Append($"Points: x: {point.X}, y: {point.Y}, ");
            }
            stingBuilder.Append($"color: {color}");
            return stingBuilder.ToString();
        }
        public void Paint(Point[] points)
        {
            var newPoints = new Point[this.points.Length + points.Length];
            for (int i = 0; i < this.points.Length; i++)
            {
                newPoints[i] = this.points[i];
            }
            for (int i = 0; i < points.Length; i++)
            {
                newPoints[i + this.points.Length] = points[i];
            }
            this.points = newPoints;
        }
        public IMemento SaveState()
        {
            return new PainterMemento(points, color);
        }
        public void Restore(IMemento memento)
        {
            points = memento.Points;
            color = memento.Color;
        }
    }
}
