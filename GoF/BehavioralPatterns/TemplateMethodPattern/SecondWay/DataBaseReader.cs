using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern.SecondWay
{
    class DataBaseReader : DataReadingAlgorithm
    {
        public override void OpenResource()
        {
            Console.WriteLine("Open data base");
        }

        public override void CloseResource()
        {
            Console.WriteLine("Close data base");
        }
    }
}
