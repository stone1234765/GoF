using GoF.CreationalPatterns.BuilderPattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.CreationalPatterns.BuilderPattern
{
    class Builder
    {
        public void Run()
        {
            Console.WriteLine("Builder");
            //First way
            Console.WriteLine("First way");
            var car = new CarBuilder().AddAutoPilot(true).AddParktronic(true).UpdateEngine("New Engine").Build();

            Console.WriteLine();
        }
    }
}
