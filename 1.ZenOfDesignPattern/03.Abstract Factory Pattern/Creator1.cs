namespace ZenOfDesignPattern.Abstract_Factory_Pattern
{
    //型号为1的生产线
    class Creator1 : AbstractCreator
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
