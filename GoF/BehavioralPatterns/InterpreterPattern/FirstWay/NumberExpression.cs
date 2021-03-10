using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.InterpreterPattern.FirstWay
{
    class NumberExpression : IExpression
    {
        private string name { get; set; }
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
