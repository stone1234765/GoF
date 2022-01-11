using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.SecondWay
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
