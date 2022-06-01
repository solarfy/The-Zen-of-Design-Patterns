namespace MixedMode.FactoryMethod_Srategy
{
    //扣款策略的封装
    class DeductionContext
    {
        IDeduction deduction;

        public DeductionContext(IDeduction deduction)
        {
            this.deduction = deduction;
        }

        public bool Exec(Card card, Trade trade)
        {
            return deduction.Exec(card, trade);
        }
    }
}
