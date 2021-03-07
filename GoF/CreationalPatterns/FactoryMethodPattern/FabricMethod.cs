using GoF.CreationalPatterns.FactoryMethodPattern.FirstWay;
using GoF.CreationalPatterns.FactoryMethodPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.FactoryMethodPattern
{
    class FabricMethod
    {
        public void Run()
        {
            Console.WriteLine("Fabric method");
            //First way
            Console.WriteLine("First way");
            var factories = new List<IFurnitureFabric>();
            factories.Add(new ChairFabric());
            factories.Add(new TableFabric());
            var furnitureCreator = new FurnitureCreator();
            furnitureCreator.CreateFurniture(factories);
            //Second way
            var factory = new BMVFactory();
            var firstBmv = factory.Create("X1");
            var secondBmv = factory.Create("X5");
            var thirdBmv = factory.Create("X6");
            Console.WriteLine();
        }
    }
}
