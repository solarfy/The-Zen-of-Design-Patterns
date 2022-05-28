namespace DesignPatternPK.AbstractFactory_VS_Builder.AbstractFactory
{
    interface ICar
    {
        //汽车生成商，也就是牌子
        string GetBand();
        //汽车的型号
        string GetModel();

        public void Run();
    }
}
