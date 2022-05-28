namespace DesignPatternPK.AbstractFactory_VS_Builder.AbstractFactory
{
    class BMWFactory : ICarFactory
    {
        public ICar CreateSuv()
        {
            return new BMWSuv();
        }

        public ICar CreateVan()
        {
            return new BMWVan();
        }
    }
}
