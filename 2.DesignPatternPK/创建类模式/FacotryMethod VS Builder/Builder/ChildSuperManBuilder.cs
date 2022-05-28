namespace DesignPatternPK.FacotryMethod_VS_Builder.Builder
{
    //小超人建造者
    class ChildSuperManBuilder : AbsBuilder
    {
        public override SuperMan CreateSuperMan()
        {
            base.superMan.Body = "瘦小的";
            base.superMan.SpecialTalent = "快速移动";
            base.superMan.SpecialSymbol = "胸前带小s标志";
            return base.superMan;
        }
    }
}
