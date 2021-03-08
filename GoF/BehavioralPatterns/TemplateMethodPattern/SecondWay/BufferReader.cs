using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern.SecondWay
{
    class BufferReader : DataReadingAlgorithm
    {
        public override void OpenResource()
        {
            Console.WriteLine("Open buffer");
        }

        public override void CloseResource()
        {
            Console.WriteLine("Close buffer");
        }
    }
}
