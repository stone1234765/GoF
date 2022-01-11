using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithIteratorFiles
{
    class Composite : IComponent
    {
        private IComponentEnumerator componentEnumerator { get; set; }
        public List<IComponent> Components { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Composite(List<IComponent> components)
        {
            Components = components;
            componentEnumerator = new IComponentEnumerator(Components);
        }

        public IEnumerator<IComponent> GetEnumerator()
        {
            //foreach (var component in GetComponents())
            //{
            //    yield return component;
            //}
            //return new IComponentEnumerator(GetComponents());
            return componentEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var component in Components)
            {
                yield return component;
            }
        }

        public List<IComponent> GetComponents()
        {
            var components = new List<IComponent>() { this };
            Components.ForEach(c => components.AddRange(c.GetComponents()));
            return components;
        }
    }
}
