namespace DesignPatternPK.FacotryMethod_VS_Builder.Builder
{
    //成年超人构建者
    class AdultSuperManBuilder : AbsBuilder
    {
        public override SuperMan CreateSuperMan()
        {
            base.superMan.Body = "强壮的身躯";
            base.superMan.SpecialTalent = "会飞行";
            base.superMan.SpecialSymbol = "胸前带大S标志";

            return base.superMan;
        }
    }
}
