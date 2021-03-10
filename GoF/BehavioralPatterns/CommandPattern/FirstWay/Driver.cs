using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.FirstWay
{
    class Driver
    {
        public IFirstCommand Command { get; set; }
        public Driver(IFirstCommand command)
        {
            Command = command;
        }
        public void Execute()
        {
            Command.Execute();
        }
        public void Execute2(Action action)
        {
            action.Invoke();
        }
    }
}
