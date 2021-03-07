using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.MediatorPattern.FirstWay
{
    class CentralController : IMediator
    {
        public AngleSensor PitchAngleSensor { get; set; }
        public AngleSensor RotateAngleSensor { get; set; }
        public AngleSensor HealingAngleSensor { get; set; }

        public BodyStabilizer Stabilizer { get; set; }
        public MovementRegulator MovementRegulator { get; set; }
        public SystemLogger Logger { get; set; }

        public CentralController(AngleSensor pitchAngleSensor, AngleSensor rotateAngleSensor, 
            AngleSensor healingAngleSensor, BodyStabilizer stabilizer,
            MovementRegulator movementRegulator, SystemLogger logger)
        {
            PitchAngleSensor = pitchAngleSensor;
            RotateAngleSensor = rotateAngleSensor;
            HealingAngleSensor = healingAngleSensor;
            Stabilizer = stabilizer;
            MovementRegulator = movementRegulator;
            Logger = logger;
        }

        public void Notify(IComponent sender, MediatorEvent mediatorEvent)
        {
            switch (mediatorEvent)
            {
                case MediatorEvent.stepExecuted:
                    PitchAngleSensor.Value = 10;
                    break;
                case MediatorEvent.angleChanged:
                    var pitchValue = PitchAngleSensor.Value;
                    Logger.Log(pitchValue);
                    if (pitchValue > 0)
                    {
                        Stabilizer.Stabilize();
                    }
                    else
                    {
                        Console.WriteLine("Stabilization is not needed");
                    }
                    break;
                case MediatorEvent.stabilizationFinished:
                    Console.WriteLine("Stabilization is finished");
                    break;
                default:
                    break;
            }
        }
        public void goForward(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (!MovementRegulator.IsCancelled)
                {
                    Console.WriteLine($"{i} step forward");
                    MovementRegulator.ExecuteStep();
                }
            }
        }
    }
}
