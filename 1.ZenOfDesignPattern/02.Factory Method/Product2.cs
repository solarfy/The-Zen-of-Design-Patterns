using System;

namespace ZenOfDesignPattern.Factory_Method
{
    class Product2 : AbstractProduct 
    {     
        public override void Method2()
        {
            Console.WriteLine("具体产品2的业务逻辑处理");
        }
    }
}
