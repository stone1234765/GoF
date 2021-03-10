using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.SecondWay
{
    class OpenState : IState
    {
        public string Description { get; set; }
        private MyTask task { get; set; }
        public OpenState()
        {
            Description = $"Opened at {DateTime.Now}";
        }
        public void SetTask(MyTask task)
        {
            this.task = task;
        }
        public void Open()
        {
            Console.WriteLine("Already opened. Do nothing.");
        }

        public void StartProgress()
        {
            task.SetState(new InProgressState());
        }

        public void StartTesting()
        {
            Console.WriteLine("Needs to start progress.");
        }
        public void Close()
        {
            task.SetState(new CloseState());
        }
    }
}
