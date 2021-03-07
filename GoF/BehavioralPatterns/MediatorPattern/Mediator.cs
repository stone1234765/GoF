using GoF.BehavioralPatterns.MediatorPattern.FirstWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern
{
    class Mediator
    {
        public void Run()
        {
            Console.WriteLine("Mediator");
            //First way
            Console.WriteLine("First way");
            var pitchAngleSensor = new AngleSensor();
            var stabilizer = new BodyStabilizer();
            var movementRegulator = new MovementRegulator();
            var logger = new SystemLogger();

            var controller = new CentralController(
                pitchAngleSensor, new AngleSensor(), new AngleSensor(),
                stabilizer, movementRegulator, logger);
            pitchAngleSensor.Mediator = controller;
            stabilizer.Mediator = controller;
            movementRegulator.Mediator = controller;
            logger.Mediator = controller;

            controller.goForward(5);



            Console.WriteLine();
        }
    }
}
