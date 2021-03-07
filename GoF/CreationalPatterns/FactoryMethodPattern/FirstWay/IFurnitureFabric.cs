using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethodPattern.FirstWay
{
    interface IFurnitureFabric
    {
        IFurniture Create();
    }
}
