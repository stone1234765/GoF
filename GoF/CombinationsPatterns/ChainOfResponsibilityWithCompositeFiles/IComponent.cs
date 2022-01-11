using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCompositeFiles
{
    interface IComponent
    {
        string Name { get; set; }
        IComponent Component { get; set; }
        bool WriteIsCostBigger(decimal order);
        decimal Price { get; set; }
    }
}
