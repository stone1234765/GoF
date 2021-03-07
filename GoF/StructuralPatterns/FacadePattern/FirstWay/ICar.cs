using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FacadePattern.FirstWay
{
    interface ICar
    {
        string Body { get; set; }
        string Engine { get; set; }
        string Interior { get; set; }
        string Exterior { get; set; }
        string Whells { get; set; }
        string Electronics { get; set; }
        string Color { get; set; }
    }
}
