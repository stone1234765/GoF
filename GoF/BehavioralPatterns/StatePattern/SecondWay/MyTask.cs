using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.SecondWay
{
    class MyTask
    {
        public string History { get; set; }
        private IState state { get; set; }
        public MyTask()
        {
            state = new OpenState();
            state.SetTask(this);
            History = $"Task history: {state.Description} ";
            Console.WriteLine($"{state.Description}");
        }
        public void SetState(IState state)
        {
            Console.WriteLine($"{state.Description}");
            this.state = state;
            state.SetTask(this);
            History += $", {state.Description}";
        }
        public void Open()
        {
            state.Open();
        }
        public void StartProgress()
        {
            state.StartProgress();
        }

        public void StartTesting()
        {
            state.StartTesting();
        }

        public void Close()
        {
            state.Close();
        }


    }
}
