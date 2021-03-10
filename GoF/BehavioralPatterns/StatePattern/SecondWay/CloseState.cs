using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.SecondWay
{
    class CloseState : IState
    {
        public string Description { get; set; }
        private MyTask task { get; set; }
        public CloseState()
        {
            Description = $"Closed at {DateTime.Now}";
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
            task.SetState(new InProgressState());
        }

        public void StartTesting()
        {
            Console.WriteLine("Needs to be opened first.");
        }
        public void Close()
        {
            Console.WriteLine("Already closed. Do nothing.");
        }
    }
}
