using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.FirstWay
{
    class WaitingForPayment : OrderStatus
    {
        public WaitingForPayment()
            : base(typeof(Shipping), "WaitingForPayment")
        {
        }
    }
}
