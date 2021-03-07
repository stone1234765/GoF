using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.FacadePattern.FirstWay
{
    class Car : ICar
    {
        public string Body { get; set; }
        public string Engine { get; set; }
        public string Interior { get; set; }
        public string Exterior { get; set; }
        public string Whells { get; set; }
        public string Electronics { get; set; }
        public string Color { get; set; }
    }
}
