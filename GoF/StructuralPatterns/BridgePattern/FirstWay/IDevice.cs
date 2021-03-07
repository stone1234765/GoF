using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.BridgePattern.FirstWay
{
    interface IDevice
    {
        void IsEnabled();
        void Enable();
        void Disable();
        void GetVolume();
        void SetVolume(int percent);
        void GetChannel();
        void SetChannel(int channel);
    }
}
