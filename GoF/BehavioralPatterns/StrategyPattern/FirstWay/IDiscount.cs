using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.FirstWay
{
    interface IDiscount
    {
        decimal CalculateDiscount(decimal amount);
    }
}
