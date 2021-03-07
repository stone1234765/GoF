 using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ChainOfResponsibilityPattern.FirstWay
{
    class Paypal : Account
    {
        public Paypal(decimal balance, Account successor = null)
        {
            Name = "Paypal";
            Balance = balance;
            Successor = successor;
        }
    }
}
