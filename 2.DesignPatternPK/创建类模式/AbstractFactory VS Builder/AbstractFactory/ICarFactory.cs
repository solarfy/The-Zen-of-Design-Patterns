namespace DesignPatternPK.AbstractFactory_VS_Builder.AbstractFactory
{
    interface ICarFactory
    {
        //生产SUV
        public ICar CreateSuv();

        //生产商务车
        public ICar CreateVan();
    }
}
