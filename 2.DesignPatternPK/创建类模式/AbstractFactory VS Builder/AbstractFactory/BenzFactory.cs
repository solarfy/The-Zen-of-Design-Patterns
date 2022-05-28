namespace DesignPatternPK.AbstractFactory_VS_Builder.AbstractFactory
{
    class BenzFactory : ICarFactory
    {
        public ICar CreateSuv()
        {
            return new BenzSuv();
        }

        public ICar CreateVan()
        {
            return new BenzVan();
        }
    }
}
