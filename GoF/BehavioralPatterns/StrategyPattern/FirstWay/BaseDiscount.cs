using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.FirstWay
{
    class BaseDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal amount)
        {
            return amount;
        }
    }
}
