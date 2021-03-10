using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.FirstWay
{
    abstract class OrderStatus
    {
        public Type NextStatus { get; set; }
        public string Name { get; set; }
        public OrderStatus(Type nextStatus, string name)
        {
            NextStatus = nextStatus;
            Name = name;
        }
        public OrderStatus Next()
        {
            return (OrderStatus)Activator.CreateInstance(NextStatus);
        }
    }
}
