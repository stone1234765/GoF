using GoF.BehavioralPatterns.InterpreterPattern.FirstWay;
using GoF.BehavioralPatterns.InterpreterPattern.SecondWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.BehavioralPatterns.InterpreterPattern
{
    class Interpreter
    {
        public void Run()
        {
            Console.WriteLine("Interpreter");
            //First way
            Console.WriteLine("First way");
            var context = new Context();

            context.SetVariable("x", 20);
            context.SetVariable("y", 32);
            context.SetVariable("z", 40);

            var expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("x"), new NumberExpression("y")),
                new NumberExpression("z")
                );
            var result = expression.Interpret(context);
            Console.WriteLine(result);


            //Second way
            Console.WriteLine("Second way");
            var roman = "MMXVIII";
            var secondContext = new SecondContext(roman);

            var tree = new List<Expression>()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (var exp in tree)
            {
                exp.Interpret(secondContext);
            }

            Console.WriteLine($"{roman} = {secondContext.Output}");

            Console.WriteLine();
        }
    }
}
