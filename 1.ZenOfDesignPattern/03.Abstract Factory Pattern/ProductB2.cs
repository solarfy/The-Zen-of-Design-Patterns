using System;

namespace ZenOfDesignPattern.Abstract_Factory_Pattern
{
    class ProductB2 : AbstractProductB
    {
        public override void DoSomething()
        {
            Console.WriteLine("具体产品B-型号2");
        }
    }
}
