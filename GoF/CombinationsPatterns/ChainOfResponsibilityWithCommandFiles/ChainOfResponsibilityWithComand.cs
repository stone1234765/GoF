using GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCommandFiles
{
    class ChainOfResponsibilityWithComand
    {
        public void Run()
        {
            Console.WriteLine("ChainOfResponsibilityWithComand");
            var firstCommand = new Command(new ATM() { Name = "First" });
            var master = new Master(firstCommand, 400);
            var secondCommand = new Command(new ATM() { Name = "Second" });
            var paypal = new Paypal(secondCommand, 300, master);
            var thirdCommand = new Command(new ATM() { Name = "Third" });
            var qiwi = new Qiwi(thirdCommand, 200, paypal);
            qiwi.Pay(400);

            var _firstCommand = new SecondWay.Command(new SecondWay.ATM() { Name = "My" });
            var _master = new SecondWay.Master(400);
            var _paypal = new SecondWay.Paypal(300, _master);
            var _qiwi = new SecondWay.Qiwi(200, _paypal);
            _qiwi.Pay(_firstCommand, 400);
            Console.WriteLine();
        }
    }
}
