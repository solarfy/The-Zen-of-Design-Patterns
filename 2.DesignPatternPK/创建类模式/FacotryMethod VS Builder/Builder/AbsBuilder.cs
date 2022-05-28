namespace DesignPatternPK.FacotryMethod_VS_Builder.Builder
{
    //抽象建造者
    abstract class AbsBuilder
    {
        //定义一个超人产品
        protected SuperMan superMan = new SuperMan();

        //构建超人的躯体
        public void SetBody(string body) => superMan.Body = body;

        //构建超人的特殊技能
        public void SetSpecialTalent(string st) => superMan.SpecialTalent = st;

        //构建超人的特殊标记
        public void SetSpecialSymbol(string ss) => superMan.SpecialSymbol = ss;

        //生成超人
        public abstract SuperMan CreateSuperMan();

    }
}
