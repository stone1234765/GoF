using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ChainOfResponsibilityPattern.FirstWay
{
    abstract class Account
    {
        public Account Successor { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public void Pay(decimal price)
        {
            if (Balance >= price)
            {
                Console.WriteLine($"Pay {price} with {Name}");
                Balance -= price;
            }
            else if (Successor != null)
            {
                Console.WriteLine($"Can not pay with {Name}");
                Successor.Pay(price);
            }
            else
            {
                Console.WriteLine("Not have many");
            }
        }
    }
}
