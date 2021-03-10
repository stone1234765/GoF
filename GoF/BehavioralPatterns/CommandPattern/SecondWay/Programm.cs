using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.CommandPattern.SecondWay
{
    class Programm
    {
        public List<ISecondCommand> Commands { get; set; }
        public Programm()
        {
            Commands = new List<ISecondCommand>();
        }
        public void Start()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
