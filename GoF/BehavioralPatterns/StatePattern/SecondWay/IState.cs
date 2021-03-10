using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.StatePattern.SecondWay
{
    interface IState
    {
        string Description { get; set; }
        void SetTask(MyTask task);
        void Open();
        void StartProgress();
        void StartTesting();
        void Close();
    }
}
