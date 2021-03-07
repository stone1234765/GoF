using GoF.StructuralPatterns.BridgePattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.BridgePattern
{
    class Bridge
    {
        public void Run()
        {
            Console.WriteLine("Bridge");
            //First way
            Console.WriteLine("First way");
            var tv = new TV();
            var tv2 = new TV();
            var radio = new Radio();
            var radio2 = new Radio();
            var remove = new SimpleRemote(tv);
            var remove2 = new SimpleRemote(tv2);
            var remove3 = new SimpleRemote(radio);
            var remove4 = new SimpleRemote(radio2);
            Manipulation(remove);
            Manipulation(remove2);
            Manipulation(remove3);
            Manipulation(remove4);
            Console.WriteLine();
        }
        private void Manipulation(IRemote remote)
        {
            remote.ChannelDown();
            Console.WriteLine();
            remote.ChannelUp();
            Console.WriteLine();
            remote.TogglePower();
            Console.WriteLine();
            remote.VolumeDown();
            Console.WriteLine();
            remote.VolumeUp();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
