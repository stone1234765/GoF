using GoF.StructuralPatterns.ProxyPattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.ProxyPattern
{
    class Proxy
    {
        public void Run()
        {
            Console.WriteLine("Proxy");
            //First way
            Console.WriteLine("First way");
            var normalLock = new Lock();
            var client = new Client(normalLock);
            client.Open();
            client.Close();
            var proxyLock = new LockProxy();
            client = new Client(proxyLock);
            client.Open();
            client.Close();
            Console.WriteLine();
        }
    }
}
