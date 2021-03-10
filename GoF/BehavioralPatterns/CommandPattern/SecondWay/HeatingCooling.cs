using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.SecondWay
{
    class HeatingCooling
    {
        public double Temperature { get; set; } = 24;
        public string Mode => Temperature >= 25 ? "heating" : "cooling";
        public void Start()
        {
            Console.WriteLine($"Start {Mode}");
        }
        public void Stop()
        {
            Console.WriteLine($"Stop {Mode}");
        }
    }
}
