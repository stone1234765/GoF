using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.CompositePattern.SecontWay
{
    abstract class Component
    {
        public abstract Guid Id { get; set; }
        public abstract decimal Price { get; set; }
        public abstract List<string> Options { get; set; }
    }
}
