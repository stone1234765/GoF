using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.InterpreterPattern.FirstWay
{
    class AddExpression : IExpression
    {
        private IExpression leftExpression { get; set; }
        private IExpression rightExpression { get; set; }
        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }
        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
}
