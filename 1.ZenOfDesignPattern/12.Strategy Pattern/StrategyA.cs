using System;

namespace ZenOfDesignPattern.Strategy_Pattern
{
    class StrategyA : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("策略A");
        }
    }
}
