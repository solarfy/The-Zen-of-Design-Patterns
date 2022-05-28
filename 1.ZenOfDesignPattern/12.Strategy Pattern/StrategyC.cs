using System;

namespace ZenOfDesignPattern.Strategy_Pattern
{
    class StrategyC : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("策略C");
        }
    }
}
