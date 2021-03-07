using GoF.StructuralPatterns.FacadePattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FacadePattern
{
    class Facade
    {
        public void Run()
        {

            Console.WriteLine("Facade");
            //First way
            Console.WriteLine("First way");
            var conveyor = new Conveyor();
            var conveyorFacade = new ConveyorFacade(conveyor);
            var car = conveyorFacade.CreateCar(new Car());
            ShowCarDetails(car);
            car = conveyorFacade.ChangeEngine(car);
            ShowCarDetails(car);

            Console.WriteLine();
        }
        private void ShowCarDetails(ICar car)
        {
            Console.WriteLine(car.Body);
            Console.WriteLine(car.Engine);
            Console.WriteLine(car.Interior);
            Console.WriteLine(car.Exterior);
            Console.WriteLine(car.Whells);
            Console.WriteLine(car.Electronics);
            Console.WriteLine(car.Color);
        }
    }
}
