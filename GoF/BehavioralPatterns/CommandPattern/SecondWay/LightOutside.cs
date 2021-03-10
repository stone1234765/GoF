using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.SecondWay
{
    class LightOutside
    {
        public double Intensity { get; set; } = 1;
        public void SwitchOn()
        {
            Console.WriteLine("Light's switched on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Light's switched off");
        }
    }
}
