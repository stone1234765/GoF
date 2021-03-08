using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern.FirstWay
{
    class BMWBuilder : Builder
    {
        public override void AddElectronic()
        {
            Console.WriteLine("Add BMW electronic");
        }

        public override void AddEngine()
        {
            Console.WriteLine("Add BMW engine");
        }

        public override void CollectAccessories()
        {
            Console.WriteLine("Add BMW accessories");
        }

        public override void InstallChassis()
        {
            Console.WriteLine("Add BMW chassis");
        }
    }
}
