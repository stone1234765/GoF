using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.CompositePattern.SecontWay
{
    class Apple : Component
    {
        private Guid id = Guid.NewGuid();
        private decimal price = 200;
        private List<string> options = new List<string>() { "Apple" };
        public override Guid Id { get => id; set => id = value; }
        public override decimal Price 
        { 
            get => price; 
            set => price = value; 
        }
        public override List<string> Options
        { 
            get => options; 
            set => options = value; 
        }
    }
}
