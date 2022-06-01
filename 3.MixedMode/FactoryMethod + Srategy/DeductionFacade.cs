namespace MixedMode.FactoryMethod_Srategy
{
    //扣款模块封装；门面模式
    class DeductionFacade
    {
        //对外公布的扣款信息
        //使用策略一进行扣款
        public static Card SteadyDeduct(Card card, Trade trade)
        {
            //获得一个消费策略，并实例化            
            IDeduction deduction = StrategyFactory.CreateDeduction(StrategyDictionary.SteadyDeduction);
            //产生一个策略上下文 (对策略进行封装，防止对外暴露策略)
            DeductionContext context = new DeductionContext(deduction);
            //进行扣款处理
            context.Exec(card, trade);
            //返回扣款处理完毕后的数据
            return card;
        }

        //使用策略二进行扣款
        public static Card FreeDeduct(Card card, Trade trade)
        {
            IDeduction deduction = StrategyFactory.CreateDeduction(StrategyDictionary.FreeDeduction);
            DeductionContext context = new DeductionContext(deduction);
            context.Exec(card, trade);
            return card;
        }

        //随机进行扣款
        public static Card RandomDeduct(Card card, Trade trade)
        {
            IDeduction deduction = StrategyFactory.RandomDeduction();
            DeductionContext context = new DeductionContext(deduction);
            context.Exec(card, trade);
            return card;
        }
    }
}
