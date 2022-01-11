using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay
{
    class ATM
    {
        public string Name { get; set; }
        public void Pay(Account account, decimal price)
        {
            Console.WriteLine($"Pay {price} with {account.Name} in command in {Name} ATM");
            account.Balance -= price;
        }
        public void CanNotPay(Account account, decimal price)
        {
            Console.WriteLine($"Can not pay with {account.Name} in command in {Name} ATM");
            account.Successor.Pay(price);
        }
    }
}
