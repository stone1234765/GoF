using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern.FirstWay
{
    class AngleSensor : IComponent
    {
        public IMediator Mediator { get; set; }
        private double value = 0;
        public double Value {
            get => value;
            set
            {
                Mediator.Notify(this, MediatorEvent.angleChanged);
                this.value = value;
            }
        }
    }
}
