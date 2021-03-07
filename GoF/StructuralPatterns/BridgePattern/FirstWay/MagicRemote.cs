using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.BridgePattern.FirstWay
{
    class MagicRemote : IRemote
    {
        protected IDevice Device { get; set; }
        public MagicRemote(IDevice device)
        {
            Device = device;
        }
        public void ChannelDown()
        {
            Console.WriteLine("MagicRemote ChannelDown");
            Device.GetChannel();
            Device.SetChannel(5);
        }

        public void ChannelUp()
        {
            Console.WriteLine("MagicRemote ChannelUp");
            Device.GetChannel();
            Device.SetChannel(10);
        }

        public void TogglePower()
        {
            Console.WriteLine("MagicRemote TogglePower");
            Device.IsEnabled();
            Device.Disable();
            Device.Enable();
        }

        public void VolumeDown()
        {
            Console.WriteLine("MagicRemote VolumeDown");
            Device.GetVolume();
            Device.SetVolume(30);
        }

        public void VolumeUp()
        {
            Console.WriteLine("MagicRemote VolumeUp");
            Device.GetVolume();
            Device.SetVolume(70);
        }
    }
}
