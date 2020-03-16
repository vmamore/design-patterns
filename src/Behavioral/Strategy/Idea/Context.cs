namespace Strategy.Idea
{
    public class Context
    {
        public Strategy Strategy { get; }
        public Context(Strategy strategy)
        {
            Strategy = strategy;
        }

        public void Method()
        {
            Strategy.Method();
        }
    }
}
