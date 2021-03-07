using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.AdapterPattern.FirstWay
{
    class Car
    {
        public Car(IEngine2 engine)
        {
            engine.SimpleInterface();
        }
    }
}
