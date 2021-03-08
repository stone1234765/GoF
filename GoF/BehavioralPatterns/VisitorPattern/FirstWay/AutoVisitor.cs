using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.VisitorPattern.FirstWay
{
    class AutoVisitor : Visitor
    {
        public override void ExportVisitor(Auto auto)
        {
            switch (auto.GetType().Name)
            {
                case nameof(Tesla):
                    Console.WriteLine($"Exported data: {(auto as Tesla).InfoTesla()}");
                    break;
                case nameof(Mers):
                    Console.WriteLine($"Exported data: {(auto as Mers).InfoMers()}");
                    break;
                case nameof(Audi):
                    Console.WriteLine($"Exported data: {(auto as Audi).InfoAudi()}");
                    break;
                case nameof(BMW):
                    Console.WriteLine($"Exported data: {(auto as BMW).InfoBMW()}");
                    break;
                default:
                    break;
            }
        }
    }
}
