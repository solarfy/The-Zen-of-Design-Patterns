namespace ZenOfDesignPattern.Abstract_Factory_Pattern
{
    //型号为2的生产线
    class Creator2 : AbstractCreator
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
