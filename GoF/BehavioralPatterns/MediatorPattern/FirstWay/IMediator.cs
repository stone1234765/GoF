using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern.FirstWay
{
    interface IMediator
    {
        void Notify(IComponent sender, MediatorEvent mediatorEvent);
    }
}
