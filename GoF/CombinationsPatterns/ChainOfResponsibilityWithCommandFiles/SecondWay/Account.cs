using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.SecondWay
{
    abstract class Account
    {
        public Account Successor { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public void Pay(ICommand command, decimal price)
        {
            if (Balance >= price)
            {
                command.Pay(this, price);
            }
            else if (Successor != null)
            {
                command.CanNotPay(this, price);
            }
            else
            {
                Console.WriteLine("Not have many");
            }
        }
    }
}
