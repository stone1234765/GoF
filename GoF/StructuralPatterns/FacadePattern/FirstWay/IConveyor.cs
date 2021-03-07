using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FacadePattern.FirstWay
{
    interface IConveyor
    {
        void SetBody(ICar car, string body);
        void GetEngine(ICar car);
        void SetEngine(ICar car, string engine);
        void SetInterior(ICar car, string interior);
        void SetExterior(ICar car, string exterior);
        void SetWhells(ICar car, string whells);
        void SetElectronics(ICar car, string electronics);
        void SetColor(ICar car, string color);
    }
}
