using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.FirstWay
{
    class Order
    {
        public OrderStatus State { get; set; }
        public Order()
        {
            State = new WaitingForPayment();
        }
        public void NextState()
        {
            State = State.Next();
        }
    }
}
