using System;

namespace ZenOfDesignPattern.Abstract_Factory_Pattern
{
    class ProductA2 : AbstractProductA
    {
        public override void DoSomething()
        {
            Console.WriteLine("具体产品A-型号2");
        }
    }
}
