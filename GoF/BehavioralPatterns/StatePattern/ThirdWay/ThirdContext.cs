using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.ThirdWay
{
    class ThirdContext
    {
        private ThirdState state { get; set; }
        public ThirdState State {
            get => state;
            set
            {
                state = value;
                Console.WriteLine($"State = {state.GetType().Name}");
            }
        }
        public ThirdContext(ThirdState state)
        {
            State = state;
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
}
