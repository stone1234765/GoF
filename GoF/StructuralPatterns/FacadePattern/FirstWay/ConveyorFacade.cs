using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FacadePattern.FirstWay
{
    class ConveyorFacade
    {
        private IConveyor Conveyor;
        public ConveyorFacade(IConveyor conveyor)
        {
            Conveyor = conveyor;
        }
        public ICar CreateCar(ICar car)
        {
            Conveyor.SetBody(car, "Body");
            Conveyor.SetEngine(car, "Engine");
            Conveyor.SetInterior(car, "Interior");
            Conveyor.SetExterior(car, "Exterior");
            Conveyor.SetWhells(car, "Whells");
            Conveyor.SetElectronics(car, "Electronics");
            Conveyor.SetColor(car, "Color");
            return car;
        }
        public ICar ChangeEngine(ICar car)
        {
            Conveyor.GetEngine(car);
            Conveyor.SetEngine(car, "NewEngine");
            return car;
        }
    }
}
