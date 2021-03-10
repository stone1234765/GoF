using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.InterpreterPattern.SecondWay
{
    class SecondContext
    {
        public string Input { get; set; }
        public int Output { get; set; }
        public SecondContext(string input)
        {
            Input = input;
        }
    }
}
