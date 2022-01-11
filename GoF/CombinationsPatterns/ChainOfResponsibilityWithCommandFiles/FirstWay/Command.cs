using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay
{
    class Command : ICommand
    {
        public ATM ATM { get; set; }
        public Command(ATM atm)
        {
            ATM = atm;
        }
        public void Pay(Account account, decimal price)
        {
            ATM.Pay(account, price);
        }
        public void CanNotPay(Account account, decimal price)
        {
            ATM.CanNotPay(account, price);
        }
    }
}
