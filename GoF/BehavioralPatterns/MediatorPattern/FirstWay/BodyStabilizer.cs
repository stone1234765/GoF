using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern.FirstWay
{
    class BodyStabilizer : IComponent
    {
        public IMediator Mediator { get; set; }
        public void Stabilize()
        {
            Console.WriteLine("Stabilize body");
            Mediator.Notify(this, MediatorEvent.stabilizationFinished);
        }
    }
}
