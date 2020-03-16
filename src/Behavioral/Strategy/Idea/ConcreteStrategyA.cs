using System;

namespace Strategy.Idea
{
    public class ConcreteStrategyA : Strategy
    {
        public override void Method()
        {
            Console.WriteLine("Calling ConcreteStrategyA Method.");
        }
    }
}
