using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.BridgePattern.FirstWay
{
    class SimpleRemote : IRemote
    {
        protected IDevice Device { get; set; }
        public SimpleRemote(IDevice device)
        {
            Device = device;
        }
        public void ChannelDown()
        {
            Console.WriteLine("SimpleRemote ChannelDown");
            Device.GetChannel();
            Device.SetChannel(5);
        }

        public void ChannelUp()
        {
            Console.WriteLine("SimpleRemote ChannelUp");
            Device.GetChannel();
            Device.SetChannel(10);
        }

        public void TogglePower()
        {
            Console.WriteLine("SimpleRemote TogglePower");
            Device.IsEnabled();
            Device.Disable();
            Device.Enable();
        }

        public void VolumeDown()
        {
            Console.WriteLine("SimpleRemote VolumeDown");
            Device.GetVolume();
            Device.SetVolume(30);
        }

        public void VolumeUp()
        {
            Console.WriteLine("SimpleRemote VolumeUp");
            Device.GetVolume();
            Device.SetVolume(70);
        }
    }
}
