using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CombinationsPatterns.ChainOfResponsibilityWithCompositeFiles
{
    class Composite : IComponent
    {
        public string Name { get; set; }
        public List<IComponent> Components { get; set; }
        public IComponent Component { get; set; }
        public decimal Price
        {
            get
            {
                if (Components == null || Components.Count < 1)
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
            if (components != null)
            {
                foreach (var component in components)
                {
                    component.Component = this;
                }
            }
        }
        public bool WriteIsCostBigger(decimal order)
        {
            if (Price < order)
            {
                if (Component != null)
                {
                    return Component.WriteIsCostBigger(order);
                }
                Console.WriteLine("No Component");
                return false;
            }
            Console.WriteLine($"{Name} is cost bigger");
            return true;
        }

    }
}
