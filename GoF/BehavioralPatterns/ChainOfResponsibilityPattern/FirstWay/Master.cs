using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ChainOfResponsibilityPattern.FirstWay
{
    class Master : Account
    {
        public Master(decimal balance, Account successor = null)
        {
            Name = "Master";
            Balance = balance;
            Successor = successor;
        }
    }
}
