namespace MixedMode.FactoryMethod_Srategy
{
    //策略字典；用于存入策略实例的一个容器，且每个策略有对应的索引
    class StrategyDictionary
    {
        //扣款策略一
        private static IDeduction steadyDeduction;
        public static IDeduction SteadyDeduction { get => steadyDeduction ??= new SteadyDeduction(); }

        //扣款策略二
        private static IDeduction freeDeduction;
        public static IDeduction FreeDeduction { get => freeDeduction ??= new FreeDeduction(); }       
    }
}
