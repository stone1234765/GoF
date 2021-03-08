using GoF.BehavioralPatterns.MementoPattern.FirstWay;
using GoF.BehavioralPatterns.MementoPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MementoPattern
{
    class Memento
    {
        public void Run()
        {
            Console.WriteLine("Memento");
            //First way
            Console.WriteLine("First way");
            var firstCaretaker = new FirstCaretaker();

            firstCaretaker.AddMemento(new Creator("First").Save());
            firstCaretaker.AddMemento(new Creator("Second").Save());
            firstCaretaker.AddMemento(new Creator("Third").Save());
            var creator = new Creator();
            creator.Restore(firstCaretaker.GetMemento(1));


            //Second way
            Console.WriteLine("Second way");
            var painter = new Painter("Black");
            var secondCaretaker = new SecondCaretaker(painter);
            painter.Paint(new Point[] { new Point(1, 1), new Point(2, 2) });
            secondCaretaker.Save();
            painter.Paint(new Point[]{ new Point(3, 3), new Point(4, 4), new Point(5, 5) });
            secondCaretaker.Save();
            painter.Paint(new Point[] { new Point(6, 6) });
            secondCaretaker.Save();
            painter.Paint(new Point[] { new Point(7, 7), new Point(8, 8) });
            secondCaretaker.Save();

            secondCaretaker.Undo(3);
            secondCaretaker.Redo(1);
            painter.Paint(new Point[] { new Point(9, 9), new Point(10, 10) });
            secondCaretaker.Save();
            secondCaretaker.Undo(2);

            Console.WriteLine();
        }
    }
}
