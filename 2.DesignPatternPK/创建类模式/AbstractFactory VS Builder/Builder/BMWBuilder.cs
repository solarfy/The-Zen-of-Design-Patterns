namespace DesignPatternPK.AbstractFactory_VS_Builder.Builder
{
    class BMWBuilder : AbsCarBuilder
    {
        public override string BuildEngine()
        {
            return base.GetBlueprint().GetEngine();     //通过基类蓝图建造
        }

        public override string BuildWheel()
        {
            return base.GetBlueprint().GetWheel();
        }

        public override string Logo()
        {
            return "宝马";
        }
    }
}
