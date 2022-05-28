namespace DesignPatternPK.AbstractFactory_VS_Builder.Builder
{
    class BenzBuilder : AbsCarBuilder
    {
        public override string BuildEngine()
        {
            return base.GetBlueprint().GetEngine();
        }

        public override string BuildWheel()
        {
            return base.GetBlueprint().GetWheel();
        }

        public override string Logo()
        {
            return "奔驰";
        }
    }
}
