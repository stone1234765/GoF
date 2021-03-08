using GoF.BehavioralPatterns.TemplateMethodPattern.FirstWay;
using GoF.BehavioralPatterns.TemplateMethodPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.TemplateMethodPattern
{
    class TemplateMethod
    {
        public void Run()
        {
            Console.WriteLine("TemplateMethod");
            //First way
            Console.WriteLine("First way");
            var teslaBuilder = new TeslaBuilder();
            var bmwBuilder = new BMWBuilder();
            teslaBuilder.Build();
            bmwBuilder.Build();


            //Second way
            Console.WriteLine("Second way");
            var fileReader = new FileReader();
            var bufferReader = new BufferReader();
            var dataBaseReader = new DataBaseReader();
            fileReader.ReadData();
            bufferReader.ReadData();
            dataBaseReader.ReadData();

            Console.WriteLine();
        }
    }
}
