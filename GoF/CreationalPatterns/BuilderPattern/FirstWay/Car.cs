using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.BuilderPattern.FirstWay
{
    class Car
    {
        public bool AutoPilot { get; set; }
        public bool Parktronic { get; set; }
        public bool Signaling { get; set; }
        public string Engine { get; set; }
        public Car()
        {
            AutoPilot = false;
            Parktronic = false;
            Signaling = false;
        }
    }
}
