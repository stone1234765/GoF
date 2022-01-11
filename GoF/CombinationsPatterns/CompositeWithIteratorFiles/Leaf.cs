using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithIteratorFiles
{
    class Leaf : IComponent
    {
        private IComponentEnumerator componentEnumerator { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Leaf(decimal price, string name)
        {
            Price = price;
            Name = name;
            componentEnumerator = new IComponentEnumerator(new List<IComponent>());
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
            return null;
        }

        public List<IComponent> GetComponents()
        {
            return new List<IComponent>() { this };
        }
    }
}
