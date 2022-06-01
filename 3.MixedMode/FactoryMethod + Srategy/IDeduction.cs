namespace MixedMode.FactoryMethod_Srategy
{
    //扣款策略接口
    interface IDeduction
    {
        //扣款，提供交易和卡号信息，进行扣款，并返回扣款是否成功
        public bool Exec(Card card, Trade trade);
    }
}
