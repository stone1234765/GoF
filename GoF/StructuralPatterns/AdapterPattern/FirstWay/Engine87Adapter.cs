using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.AdapterPattern.FirstWay
{
    class Engine87Adapter : IEngine2
    {
        private IEngine87 Engine { get; set; }
        public Engine87Adapter(IEngine87 engine)
        {
            Engine = engine;
        }
        public void SimpleInterface()
        {
            Engine.ComplicatedInterface();
        }
    }
}
