using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern.FirstWay
{
    class SystemLogger : IComponent
    {
        public IMediator Mediator { get; set; }

        public void Log(double pitch)
        {
            Console.WriteLine($"Logging pitch {pitch}");
        }
    }
}
