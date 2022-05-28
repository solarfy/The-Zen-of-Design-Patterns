using System;

namespace ZenOfDesignPattern.Builder_Pattern
{
    //具体产品类；如果有多个产品类，则多个产品类需具有相同的接口或抽象类。
    class Product
    {        
        public void DoSomething()
        {
            Console.WriteLine("业务逻辑 DoSomething");
        }
    }
}
