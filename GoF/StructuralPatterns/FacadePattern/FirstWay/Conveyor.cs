using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FacadePattern.FirstWay
{
    class Conveyor : IConveyor
    {
        public void SetBody(ICar car, string body)
        {
            car.Body = body;
        }
        public void GetEngine(ICar car)
        {
            car.Engine = null;
        }
        public void SetEngine(ICar car, string engine)
        {
            car.Engine = engine;
        }
        public void SetInterior(ICar car, string interior)
        {
            car.Interior = interior;
        }
        public void SetExterior(ICar car, string exterior)
        {
            car.Exterior = exterior;
        }
        public void SetWhells(ICar car, string whells)
        {
            car.Whells = whells;
        }
        public void SetElectronics(ICar car, string electronics)
        {
            car.Electronics = electronics;
        }
        public void SetColor(ICar car, string color)
        {
            car.Color = color;
        }
    }
}
