using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.ProxyPattern.FirstWay
{
    interface ILock
    {
        void Open();
        void Close();
    }
}
