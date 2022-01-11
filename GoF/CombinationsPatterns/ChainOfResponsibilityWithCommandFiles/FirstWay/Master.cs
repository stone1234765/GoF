using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay
{
    class Master : Account
    {
        public Master(ICommand command, decimal balance, Account successor = null)
        {
            Command = command;
            Name = "Master";
            Balance = balance;
            Successor = successor;
        }
    }
}
