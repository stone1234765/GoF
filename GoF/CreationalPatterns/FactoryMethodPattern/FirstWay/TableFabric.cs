using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethodPattern.FirstWay
{
    class TableFabric : IFurnitureFabric
    {
        public IFurniture Create()
        {
            Console.WriteLine("Create table");
            return new Table();
        }
    }
}
