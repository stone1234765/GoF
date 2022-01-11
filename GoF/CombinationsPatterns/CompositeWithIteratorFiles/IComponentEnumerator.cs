using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GoF.CombinationsPatterns.CompositeWithIteratorFiles
{
    class IComponentEnumerator : IEnumerator<IComponent>
    {
        private List<IComponent> Components;
        private int position = -1;
        public IComponentEnumerator(List<IComponent> components)
        {
            Components = components;
        }
        public IComponent Current
        {
            get
            {
                if (position == -1)
                {
                    position++;
                }
                if (position >= Components.Count)
                {
                    return null;
                }
                if (Components[position] != null
                    && Components[position].GetEnumerator().Current != null
                    )
                {
                    return Components[position].GetEnumerator().Current;
                }
                return Components[position];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (position < 0)
            {
                //position++;
                return true;
            }
            if (position >= Components.Count - 1)
            {
                return false;
            }
            if (Components[position] != null && Components[position].GetEnumerator().MoveNext())
            {
                return true;
            }
            else
            if (position < Components.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
