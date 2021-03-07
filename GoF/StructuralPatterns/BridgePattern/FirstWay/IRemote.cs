using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.StructuralPatterns.BridgePattern.FirstWay
{
    interface IRemote
    {
        void TogglePower();
        void VolumeUp();
        void VolumeDown();
        void ChannelUp();
        void ChannelDown();
    }
}
