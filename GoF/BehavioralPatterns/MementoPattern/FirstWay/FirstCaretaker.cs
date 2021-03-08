using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern.FirstWay
{
    class FirstCaretaker
    {
        public List<FirstMemento> Mementos { get; set; }
        public FirstCaretaker()
        {
            Mementos = new List<FirstMemento>();
        }

        public void AddMemento(FirstMemento memento)
        {
            Mementos.Add(memento);
        }

        public FirstMemento GetMemento(int index)
        {
            return Mementos[index];
        }
    }
}
