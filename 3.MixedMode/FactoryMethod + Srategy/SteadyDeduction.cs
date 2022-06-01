using System;

namespace MixedMode.FactoryMethod_Srategy
{
    //扣款策略一
    class SteadyDeduction : IDeduction
    {
        //固定金额和自由金额各扣除50%
        public bool Exec(Card card, Trade trade)
        {            
            int halfMoney = (int)Math.Round(trade.Amount / 2.0);
            card.FreeMoney -= halfMoney;
            card.SteadyMoney -= halfMoney;

            return true;
        }
    }
}
