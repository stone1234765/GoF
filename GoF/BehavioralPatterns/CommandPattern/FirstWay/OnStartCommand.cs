using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.FirstWay
{
    class OnStartCommand : IFirstCommand
    {
        public Engine Engine { get; set; }
        public OnStartCommand(Engine engine)
        {
            Engine = engine;
        }
        public void Execute()
        {
            Engine.On();
        }
    }
}
