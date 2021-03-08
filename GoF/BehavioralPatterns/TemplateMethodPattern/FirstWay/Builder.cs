using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern.FirstWay
{
    abstract class Builder
    {
        public abstract void AddEngine();
        public abstract void InstallChassis();
        public abstract void AddElectronic();
        public abstract void CollectAccessories();

        public void Build()
        {
            AddEngine();
            InstallChassis();
            AddElectronic();
            CollectAccessories();
            Console.WriteLine();
        }
    }
}
