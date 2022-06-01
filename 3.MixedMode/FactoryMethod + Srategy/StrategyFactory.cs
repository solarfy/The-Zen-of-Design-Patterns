using System;

namespace MixedMode.FactoryMethod_Srategy
{
    //策略工厂
    static class StrategyFactory
    {
        public static IDeduction CreateDeduction(IDeduction deduction)
        {
            return deduction;
        }

        //随机产生一个策略
        public static IDeduction RandomDeduction()
        {
            int r = new Random().Next(2);   //小于2的非负随机整数：0、1
            return r != 0 ? StrategyDictionary.SteadyDeduction : StrategyDictionary.FreeDeduction;
        }
    }
}
