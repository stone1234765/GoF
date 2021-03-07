using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FlyweightPattern.SecondWay
{
    class AutoFactory
    {
        private Dictionary<string, IAuto> Autos = new Dictionary<string, IAuto>();

        public IAuto MakeAuto(string model)
        {
            if (Autos.ContainsKey(model))
            {
                return Autos[model];
            }
            else
            {
                var auto = new ConcreteAuto(model);
                Autos[model] = auto;
                return auto;
            }
        }
    }
}
