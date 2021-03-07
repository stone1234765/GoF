using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FlyweightPattern.SecondWay
{
    class ConcreteAuto : IAuto
    {
        public string Model { get; set; }
        public ConcreteAuto(string model)
        {
            Model = model;
        }
    }
}
