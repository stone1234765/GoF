using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.SecondWay
{
    interface IFilterStrategy
    {
        Image Process(Image image);
    }
}
