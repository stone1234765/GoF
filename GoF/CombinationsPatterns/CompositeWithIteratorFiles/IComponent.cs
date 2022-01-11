using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithIteratorFiles
{
    interface IComponent : IEnumerable<IComponent>
    {
        string Name { get; set; }
        decimal Price { get; set; }
        List<IComponent> GetComponents();
    }
}
