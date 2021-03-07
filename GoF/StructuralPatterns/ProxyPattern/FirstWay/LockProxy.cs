using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.ProxyPattern.FirstWay
{
    class LockProxy : ILock
    {
        private Lock Lock = new Lock();
        public void Open()
        {
            if (AnyUser.IsLogin)
            {
                Lock.Open();
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
        public void Close()
        {
            Lock.Close();
        }
    }
}
