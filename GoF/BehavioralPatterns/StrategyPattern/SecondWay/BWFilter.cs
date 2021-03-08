using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.SecondWay
{
    class BWFilter : IFilterStrategy
    {
        public Image Process(Image image)
        {
            Console.WriteLine("Apply BWFilter to image");
            return image;
        }
    }
}
