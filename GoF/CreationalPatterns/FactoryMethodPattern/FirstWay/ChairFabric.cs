using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethodPattern.FirstWay
{
    class ChairFabric : IFurnitureFabric
    {
        public IFurniture Create()
        {
            Console.WriteLine("Create chair");
            return new Chair();
        }
    }
}
