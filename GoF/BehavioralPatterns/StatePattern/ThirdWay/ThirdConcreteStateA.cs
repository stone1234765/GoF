using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.ThirdWay
{
    class ThirdConcreteStateA : ThirdState
    {
        public override void Handle(ThirdContext context)
        {
            context.State = new ThirdConcreteStateB();
        }
    }
}
