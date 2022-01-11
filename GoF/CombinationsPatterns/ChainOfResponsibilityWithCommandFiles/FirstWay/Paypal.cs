using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay
{
    class Paypal : Account
    {
        public Paypal(ICommand command, decimal balance, Account successor = null)
        {
            Command = command;
            Name = "Paypal";
            Balance = balance;
            Successor = successor;
        }
    }
}
