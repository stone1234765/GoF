using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.FirstWay
{
    class Delivered : OrderStatus
    {
        public Delivered()
            : base(typeof(Delivered), "Delivered")
        {
        }
    }
}
