using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.FirstWay
{
    class OnSwitchOffCommand : IFirstCommand
    {
        public Engine Engine { get; set; }
        public OnSwitchOffCommand(Engine engine)
        {
            Engine = engine;
        }
        public void Execute()
        {
            Engine.Off();
        }
    }
}
