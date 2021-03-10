using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.SecondWay
{
    class InTestingState : IState
    {
        public string Description { get; set; }
        private MyTask task { get; set; }
        public InTestingState()
        {
            Description = $"In testing: {DateTime.Now}";
        }
        public void SetTask(MyTask task)
        {
            this.task = task;
        }
        public void Open()
        {
            Console.WriteLine("Needs to be close first.");
        }

        public void StartProgress()
        {
            task.SetState(new InProgressState());
        }

        public void StartTesting()
        {
            Console.WriteLine("Already in testing. Do nothing.");
        }
        public void Close()
        {
            task.SetState(new CloseState());
        }
    }
}
