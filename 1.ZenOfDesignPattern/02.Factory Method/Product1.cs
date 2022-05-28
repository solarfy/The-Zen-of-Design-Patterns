using System;

namespace ZenOfDesignPattern.Factory_Method
{
    class Product1 : AbstractProduct
    {
        public override void Method2()
        {
            Console.WriteLine("具体产品1的业务逻辑处理");
        }
    }
}
