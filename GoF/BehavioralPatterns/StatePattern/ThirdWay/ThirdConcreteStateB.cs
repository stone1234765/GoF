using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.ThirdWay
{
    class ThirdConcreteStateB : ThirdState
    {
        public override void Handle(ThirdContext context)
        {
            context.State = new ThirdConcreteStateA();
        }
    }
}
