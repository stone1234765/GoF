using GoF.BehavioralPatterns.ChainOfResponsibilityPattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.ChainOfResponsibilityPattern
{
    class ChainOfResponsibility
    {
        public void Run()
        {
            Console.WriteLine("ChainOfResponsibility");
            //First way
            Console.WriteLine("First way");
            var qiwi = new Qiwi(1000);
            var master = new Master(1500);
            var paypal = new Paypal(2000);
            qiwi.Successor = master;
            master.Successor = paypal;

            qiwi.Pay(1700);

            Console.WriteLine();
        }
    }
}
