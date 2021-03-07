using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethodPattern.SecondWay
{
    class BMVFactory
    {
        public BMV Create(string type)
        {
            switch (type)
            {
                case "X1":
                    return new BMV(type, 10000, 220);
                case "X5":
                    return new BMV(type, 100000, 340);
                default:
                    return new BMV();
            }
        }
    }
}
