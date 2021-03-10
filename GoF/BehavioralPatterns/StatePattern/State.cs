using GoF.BehavioralPatterns.StatePattern.FirstWay;
using GoF.BehavioralPatterns.StatePattern.SecondWay;
using GoF.BehavioralPatterns.StatePattern.ThirdWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern
{
    class State
    {
        public void Run()
        {
            Console.WriteLine("State");
            //First way
            Console.WriteLine("First way");
            var order = new Order();
            Console.WriteLine(order.State.Name);
            order.NextState();
            Console.WriteLine(order.State.Name);
            order.NextState();
            Console.WriteLine(order.State.Name);
            order.NextState();
            Console.WriteLine(order.State.Name);
            order.NextState();


            //Second way
            Console.WriteLine("Second way");
            var myTask = new MyTask();
            myTask.StartProgress();
            myTask.StartTesting();
            myTask.Open();
            myTask.Close();
            myTask.StartTesting();
            myTask.StartProgress();
            Console.WriteLine(myTask.History);

            //Third way
            Console.WriteLine("Third way");
            var context = new ThirdContext(new ThirdConcreteStateA());
            context.Request();
            context.Request();
            context.Request();

            Console.WriteLine();
        }
    }
}
