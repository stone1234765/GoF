using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.FirstWay
{
    class Shipping : OrderStatus
    {
        public Shipping()
            : base(typeof(Delivered), "Shipping")
        {
        }
    }
}
