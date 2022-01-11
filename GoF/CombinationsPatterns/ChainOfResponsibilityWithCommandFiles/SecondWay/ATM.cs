using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.SecondWay
{
    class ATM
    {
        public string Name { get; set; }
        public void Pay(Account account, decimal price)
        {
            Console.WriteLine($"Pay {price} with {account.Name} in command in {Name} ATM");
            account.Balance -= price;
        }
        public void CanNotPay(ICommand command, Account account, decimal price)
        {
            Console.WriteLine($"Can not pay with {account.Name} in command in {Name} ATM");
            account.Successor.Pay(command, price);
        }
    }
}
