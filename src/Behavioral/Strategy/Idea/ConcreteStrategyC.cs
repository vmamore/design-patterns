using System;

namespace Strategy.Idea
{
    public class ConcreteStrategyC : Strategy
    {
        public override void Method()
        {
            Console.WriteLine("Calling ConcreteStrategyC Method.");
        }
    }
}
