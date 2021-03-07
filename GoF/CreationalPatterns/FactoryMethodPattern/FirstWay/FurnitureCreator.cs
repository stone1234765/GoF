using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethodPattern.FirstWay
{
    class FurnitureCreator
    {
        public void CreateFurniture(List<IFurnitureFabric> fabries)
        {
            foreach (var fabric in fabries)
            {
                fabric.Create();
            }
        }
    }
}
