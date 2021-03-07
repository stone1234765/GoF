using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.PrototypePattern.FirstWay
{
    class Audi : Auto
    {
        public Audi(Guid id, decimal price, double maxSpeed)
            : base(id, price, maxSpeed)
        {

        }

        public override Auto Clone()
        {
            return new Audi(Id, Price, MaxSpeed);
        }
    }
}
