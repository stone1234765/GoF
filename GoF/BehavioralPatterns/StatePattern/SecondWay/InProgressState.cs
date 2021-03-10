using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.SecondWay
{
    class InProgressState : IState
    {
        public string Description { get; set; }
        private MyTask task { get; set; }
        public InProgressState()
        {
            Description = $"In progress: {DateTime.Now}";
        }
        public void SetTask(MyTask task)
        {
            this.task = task;
        }
        public void Open()
        {
            task.SetState(new OpenState());
        }

        public void StartProgress()
        {
            Console.WriteLine("Already in progress. Do nothing.");
        }

        public void StartTesting()
        {
            task.SetState(new InTestingState());
        }
        public void Close()
        {
            Console.WriteLine("Needs to be testing first.");
        }
    }
}
