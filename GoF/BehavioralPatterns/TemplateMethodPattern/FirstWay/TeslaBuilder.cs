using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern.FirstWay
{
    class TeslaBuilder : Builder
    {
        public override void AddElectronic()
        {
            Console.WriteLine("Add Tesla electronic");
        }

        public override void AddEngine()
        {
            Console.WriteLine("Add Tesla engine");
        }

        public override void CollectAccessories()
        {
            Console.WriteLine("Add Tesla accessories");
        }

        public override void InstallChassis()
        {
            Console.WriteLine("Add Tesla chassis");
        }
    }
}
