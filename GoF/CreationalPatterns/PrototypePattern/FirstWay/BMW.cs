using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.PrototypePattern.FirstWay
{
    class BMW : Auto
    {
        public BMW(Guid id, decimal price, double maxSpeed)
            : base(id, price, maxSpeed)
        {

        }

        public override Auto Clone()
        {
            return new BMW(Id, Price, MaxSpeed);
        }
    }
}
