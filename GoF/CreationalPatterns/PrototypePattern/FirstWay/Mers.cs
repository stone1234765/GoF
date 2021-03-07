using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.PrototypePattern.FirstWay
{
    class Mers : Auto
    {
        public Mers(Guid id, decimal price, double maxSpeed)
            :base(id, price, maxSpeed)
        {

        }

        public override Auto Clone()
        {
            return new Mers(Id, Price, MaxSpeed);
        }
    }
}
