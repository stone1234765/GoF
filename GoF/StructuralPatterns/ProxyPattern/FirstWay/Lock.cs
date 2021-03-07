using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.ProxyPattern.FirstWay
{
    class Lock : ILock
    {
        public void Open()
        {
            Console.WriteLine("Open");
        }
        public void Close()
        {
            Console.WriteLine("Close");
        }

    }
}
