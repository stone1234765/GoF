using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.SecondWay
{
    class SepiaFilter : IFilterStrategy
    {
        public Image Process(Image image)
        {
            Console.WriteLine("Apply SepiaFilter to image");
            return image;
        }
    }
}
