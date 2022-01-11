using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay
{
    abstract class Account
    {
        public ICommand Command { get; set; }
        public Account Successor { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public void Pay(decimal price)
        {
            if (Balance >= price)
            {
                Command.Pay(this, price);
            }
            else if (Successor != null)
            {
                Command.CanNotPay(this, price);
            }
            else
            {
                Console.WriteLine("Not have many");
            }
        }
    }
}
