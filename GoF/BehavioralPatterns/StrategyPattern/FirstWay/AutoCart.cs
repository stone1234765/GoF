using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StrategyPattern.FirstWay
{
    class AutoCart
    {
        public IDiscount Discount { get; set; }
        public decimal Amount { get; set; }
        public AutoCart(IDiscount discount, decimal amount)
        {
            Discount = discount;
            Amount = amount;
        }
        public AutoCart(decimal amount)
        {
            Amount = amount;
        }

        public void ShowDiscount()
        {
            var discount = Discount.CalculateDiscount(Amount);
            Console.WriteLine(discount);
        }
    }
}
