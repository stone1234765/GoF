using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay
{
    interface ICommand
    {
        ATM ATM { get; set; }
        void Pay(Account account, decimal price);
        void CanNotPay(Account account, decimal price);
    }
}
