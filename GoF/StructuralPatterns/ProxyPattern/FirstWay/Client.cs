using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.ProxyPattern.FirstWay
{
    class Client
    {
        private ILock Lock;
        public Client(ILock lockk)
        {
            Lock = lockk;
        }
        public void Open()
        {
            Lock.Open();
        }
        public void Close()
        {
            Lock.Close();
        }
    }
}
