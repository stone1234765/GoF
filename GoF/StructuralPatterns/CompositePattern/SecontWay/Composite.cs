using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.StructuralPatterns.CompositePattern.SecontWay
{
    abstract class Composite : Component
    {
        private List<Component> components = new List<Component>();
        public virtual List<Component> Components { get => components; set => components = value; }
        public virtual void AddComponent(Component component)
        {
            Components.Add(component);
        }
        public virtual void RemoveComponent(Component component)
        {
            Components.Remove(component);
        }


        private Guid id = Guid.NewGuid();
        public override Guid Id { get => id; set => id = value; }
        public override decimal Price
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
        public override List<string> Options
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
    }
}
