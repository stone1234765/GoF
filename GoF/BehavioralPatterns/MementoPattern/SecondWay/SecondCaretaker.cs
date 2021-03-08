using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern.SecondWay
{
    class SecondCaretaker
    {
        private List<IMemento> mementos { get; set; }
        private int index { get; set; }
        private Painter painter { get; set; }
        public SecondCaretaker(Painter painter)
        {
            this.painter = painter;
            mementos = new List<IMemento>();
            index = 0;
        }
        public void Save()
        {
            var tail = mementos.Count - 1 - index;
            if (tail > 0)
            {
                mementos.RemoveRange(index, tail);
            }
            mementos.Add(painter.SaveState());
            index = mementos.Count - 1;
            Console.WriteLine($"Save: {painter.Description()}");
        }
        public void Undo(int steps)
        {
            if (steps - index < 0)
            {
                Console.WriteLine("Can not undo");
            }
            else
            {
                index -= steps;
                painter.Restore(mementos[index]);
                Console.WriteLine($"Undo: {painter.Description()}");
            }
        }
        public void Redo(int steps)
        {
            if (steps + index > mementos.Count - 1)
            {
                Console.WriteLine("Can not redo");
            }
            else
            {
                index += steps;
                painter.Restore(mementos[index]);
                Console.WriteLine($"Redo: {painter.Description()}");
            }
        }
    }
}
