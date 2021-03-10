using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.InterpreterPattern.FirstWay
{
    class Context
    {
        private Dictionary<string, int> variables { get; set; }
        public Context()
        {
            variables = new Dictionary<string, int>();
        }
        public int GetVariable(string name)
        {
            return variables[name];
        }
        public void SetVariable(string name, int value)
        {
            if (variables.ContainsKey(name))
            {
                variables[name] = value;
            }
            else
            {
                variables.Add(name, value);
            }
        }
    }
}
