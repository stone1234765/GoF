using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern.FirstWay
{
    class MovementRegulator : IComponent
    {
        public IMediator Mediator { get; set; }
        public bool IsCancelled = false;
        public void ExecuteStep()
        {
            if (!IsCancelled)
            {
                Mediator.Notify(this, MediatorEvent.stepExecuted);
            }
        }
    }
}
