using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.BridgePattern.FirstWay
{
    class Radio : IDevice
    {
        public void Disable()
        {
            Console.WriteLine("Radio Disable");
        }

        public void Enable()
        {
            Console.WriteLine("Radio Enable");
        }

        public void GetChannel()
        {
            Console.WriteLine("Radio GetChannel");
        }

        public void GetVolume()
        {
            Console.WriteLine("Radio GetVolume");
        }

        public void IsEnabled()
        {
            Console.WriteLine("Radio IsEnabled");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Radio SetChannel {channel}");
        }

        public void SetVolume(int percent)
        {
            Console.WriteLine($"Radio SetVolume {percent}");
        }
    }
}
