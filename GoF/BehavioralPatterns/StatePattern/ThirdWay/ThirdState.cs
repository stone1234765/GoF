using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.ThirdWay
{
    abstract class ThirdState
    {
        public abstract void Handle(ThirdContext context);
    }
}
