using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.SecondWay
{
    class DistortionFilter : IFilterStrategy
    {
        public Image Process(Image image)
        {
            Console.WriteLine("Apply DistortionFilter to image");
            return image;
        }
    }
}
