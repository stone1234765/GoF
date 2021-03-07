using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.AdapterPattern.FirstWay
{
    class Engine2 : IEngine2
    {
        public void SimpleInterface()
        {
            Console.WriteLine("Run Engine2");
        }
    }
}
