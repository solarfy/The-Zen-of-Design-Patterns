using System;

namespace ZenOfDesignPattern.Builder_Pattern
{
    //具体建造者类；如果有多个产品就有多个建造者，产品类之间需具有相同的接口或抽象类。
    class Builder : AbstractBuilder
    {
        private Product product = new Product();

        public override Product BuildProduct()
        {
            return product;
        }

        public override void SetPart()
        {
            Console.WriteLine("组装产品 SetPart");
        }
    }
}
