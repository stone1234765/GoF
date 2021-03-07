using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.StructuralPatterns.CompositePattern.FirstWay
{
    class Composite : IComponent
    {
        private List<IComponent> Components = new List<IComponent>();


        private Guid id = Guid.NewGuid();
        public Guid Id { get => id; set => id = value; }
        public decimal Price
        {
            get
            {
                if (Components.Count > 0)
                {
                    return Components.Select(c => c.Price).Aggregate((first, second) => first + second);
                }
                return 0;
            }
            set => Price = value; 
        }
        public List<string> Options
        {
            get
            {
                if (Components.Count > 0)
                {
                    return Components.SelectMany(c => c.Options).ToList();
                }
                return new List<string>();
            }
            set => Options = value; 
        }


        public void AddComponent(IComponent component)
        {
            Components.Add(component);
        }
        public void RemoveComponent(IComponent component)
        {
            Components.Remove(component);
        }
    }
}
