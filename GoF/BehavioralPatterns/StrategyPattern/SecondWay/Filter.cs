using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.SecondWay
{
    class Filter
    {
        public IFilterStrategy FilterStrategy { get; set; }
        
        public void ApplyFilter(Image image)
        {
            var perfectImage = FilterStrategy.Process(image);
        }
    }
}
