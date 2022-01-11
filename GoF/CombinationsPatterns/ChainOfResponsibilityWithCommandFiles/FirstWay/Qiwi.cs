using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay
{
    class Qiwi : Account
    {
        public Qiwi(ICommand command, decimal balance, Account successor = null)
        {
            Command = command;
            Name = "Qiwi";
            Balance = balance;
            Successor = successor;
        }
    }
}
