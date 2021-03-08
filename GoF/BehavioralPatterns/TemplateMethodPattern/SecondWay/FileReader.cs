using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern.SecondWay
{
    class FileReader : DataReadingAlgorithm
    {
        public override void OpenResource()
        {
            Console.WriteLine("Open file");
        }

        public override void CloseResource()
        {
            Console.WriteLine("Close file");
        }
    }
}
