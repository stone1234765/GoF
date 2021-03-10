using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.FirstWay
{
    class Engine
    {
        public bool IsOn { get; set; }
        public Engine()
        {
            IsOn = false;
        }
        public void On()
        {
            IsOn = true;
            Console.WriteLine($"On = {IsOn}");
        }
        public void Off()
        {
            IsOn = false;
            Console.WriteLine($"On = {IsOn}");
        }
    }
}
