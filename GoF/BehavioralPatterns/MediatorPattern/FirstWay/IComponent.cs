using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern.FirstWay
{
    interface IComponent
    {
        public IMediator Mediator { get; set; }
    }
}
