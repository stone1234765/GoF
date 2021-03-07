using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FlyweightPattern.SecondWay
{
    class UnsharedConcreteAuto : IAuto
    {
        public string Model { get; set; }
    }
}
