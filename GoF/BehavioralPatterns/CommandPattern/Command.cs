using GoF.BehavioralPatterns.CommandPattern.FirstWay;
using GoF.BehavioralPatterns.CommandPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern
{
    class Command
    {
        public void Run()
        {
            Console.WriteLine("Command");
            //First way
            Console.WriteLine("First way");
            var engine = new Engine();
            var onStartCommand = new OnStartCommand(engine);
            var onSwitchOffCommand = new OnSwitchOffCommand(engine);
            var driver = new Driver(onStartCommand);
            driver.Execute();
            driver = new Driver(onSwitchOffCommand);
            driver.Execute();
            driver.Execute2(onSwitchOffCommand.Execute);

            //Second way
            Console.WriteLine("Second way");
            var lightOutside = new LightOutside();
            var heatingCooling = new HeatingCooling();

            var switchOnCommand = new SwitchOnCommand(lightOutside);
            var startHeatingCommand = new StartHeatingCommand(heatingCooling);

            var programm = new Programm();
            programm.Commands.AddRange(new List<ISecondCommand>() { switchOnCommand, startHeatingCommand });
            programm.Start();

            Console.WriteLine();
        }
    }
}
