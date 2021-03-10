using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.InterpreterPattern.FirstWay
{
    interface IExpression
    {
        int Interpret(Context context);
    }
}
