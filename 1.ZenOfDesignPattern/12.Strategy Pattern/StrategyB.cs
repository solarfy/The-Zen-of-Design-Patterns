using System;

namespace ZenOfDesignPattern.Strategy_Pattern
{
    class StrategyB : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("策略B");
        }
    }
}
