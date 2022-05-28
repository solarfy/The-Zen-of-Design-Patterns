namespace DesignPatternPK.AbstractFactory_VS_Builder.Builder
{
    interface ICar
    {
        //汽车车轮
        string Wheel { get; set; }

        //汽车引擎
        string Engine { get; set; }

        void Run();
    }
}
