namespace MixedMode.FactoryMethod_Srategy
{
    //IC卡类 (如果Card是值类型，注意使用引用)
    class Card
    {
        //IC卡号码
        private string cardNo;

        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        //卡内的固定交易金额
        private int steadyMoney;

        public int SteadyMoney
        {
            get { return steadyMoney; }
            set { steadyMoney = value; }
        }

        //卡内的自由交易金额
        private int freeMoney;

        public int FreeMoney
        {
            get { return freeMoney; }
            set { freeMoney = value; }
        }

        public Card(string cardNo, int steady, int free)
        {
            this.cardNo = cardNo;
            this.steadyMoney = steady;
            this.freeMoney = free;
        }

        public override string ToString()
        {
            return $"卡号：{CardNo} \t固定类型余额：{steadyMoney / 100} \t自由类型余额：{freeMoney / 100}";
        }
    }
}
