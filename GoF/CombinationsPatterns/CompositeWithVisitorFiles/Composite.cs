using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithVisitorFiles
{
    class Composite : IComponent
    {
        public List<IComponent> Components { get; set; }
        public string Name { get; set; }
        public decimal Price { 
            get
            {
                if (Components == null)
                {
                    return 0;
                }
                return Components.Select(c => c.Price).Aggregate((first, second) => first + second);
            }
            set => Price = value;
        }
        public Composite(List<IComponent> components)
        {
            Components = components;
        }


        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
