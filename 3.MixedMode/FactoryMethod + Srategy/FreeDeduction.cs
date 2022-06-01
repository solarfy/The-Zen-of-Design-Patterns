namespace MixedMode.FactoryMethod_Srategy
{
    //扣款策略二
    class FreeDeduction : IDeduction
    {
        //直接从自由金额中扣除
        public bool Exec(Card card, Trade trade)
        {
            card.FreeMoney -= trade.Amount;
            return true;
        }
    }
}
