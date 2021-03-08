using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.FirstWay
{
    class PremiumDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * (decimal)0.5;
        }
    }
}
