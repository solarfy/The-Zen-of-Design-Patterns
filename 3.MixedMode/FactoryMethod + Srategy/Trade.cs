namespace MixedMode.FactoryMethod_Srategy
{
    //交易类
    class Trade
    {
        //交易编号
        private string tradeNo;

        public string TradeNo
        {
            get { return tradeNo; }
            set { tradeNo = value; }
        }

        //交易金额
        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Trade(string tradeNo, int amount)
        {
            this.tradeNo = tradeNo;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"交易编号：{tradeNo} \t交易金额：{Amount / 100}";
        }
    }
}
