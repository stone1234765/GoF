using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.SecondWay
{
    class StartHeatingCommand : ISecondCommand
    {
        public HeatingCooling HeatingCooling { get; set; }
        public StartHeatingCommand(HeatingCooling heatingCooling)
        {
            HeatingCooling = heatingCooling;
        }
        public void Execute()
        {
            if (HeatingCooling.Temperature < 25)
            {
                HeatingCooling.Temperature = 25;
            }
            HeatingCooling.Start();
        }
    }
}
