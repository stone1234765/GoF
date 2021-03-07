using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.BridgePattern.FirstWay
{
    class TV : IDevice
    {
        public void Disable()
        {
            Console.WriteLine("TV Disable");
        }

        public void Enable()
        {
            Console.WriteLine("TV Enable");
        }

        public void GetChannel()
        {
            Console.WriteLine("TV GetChannel");
        }

        public void GetVolume()
        {
            Console.WriteLine("TV GetVolume");
        }

        public void IsEnabled()
        {
            Console.WriteLine("TV IsEnabled");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"TV SetChannel {channel}");
        }

        public void SetVolume(int percent)
        {
            Console.WriteLine($"TV SetVolume {percent}");
        }
    }
}
