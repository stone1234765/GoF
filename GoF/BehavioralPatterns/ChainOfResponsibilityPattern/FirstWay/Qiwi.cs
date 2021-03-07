using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ChainOfResponsibilityPattern.FirstWay
{
    class Qiwi : Account
    {
        public Qiwi(decimal balance, Account successor = null)
        {
            Name = "Qiwi";
            Balance = balance;
            Successor = successor;
        }
    }
}
