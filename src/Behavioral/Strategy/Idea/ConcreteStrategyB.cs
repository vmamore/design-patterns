using System;

namespace Strategy.Idea
{
    public class ConcreteStrategyB : Strategy
    {
        public override void Method()
        {
            Console.WriteLine("Calling ConcreteStrategyB Method.");
        }
    }
}
