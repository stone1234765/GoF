using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.CompositePattern.FirstWay
{
    class Mouse : IComponent
    {
        private Guid id = Guid.NewGuid();
        private decimal price = 250;
        private List<string> options = new List<string>() { "Mouse" };
        public Guid Id { get => id; set => id = value; }
        public decimal Price { get => price; set => price = value; }
        public List<string> Options { get => options; set => options = value; }
    }
}
