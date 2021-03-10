using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.SecondWay
{
    class SwitchOnCommand : ISecondCommand
    {
        public LightOutside LightOutside { get; set; }
        public SwitchOnCommand(LightOutside lightOutside)
        {
            LightOutside = lightOutside;
        }
        public void Execute()
        {
            LightOutside.SwitchOn();
        }
    }
}
