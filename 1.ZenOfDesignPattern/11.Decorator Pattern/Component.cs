using System;

namespace ZenOfDesignPattern.Decorator_Pattern
{
    //具体构建；最核心，最原始，最基本的接口或抽象类的实现，要装饰的就是它。
    public class Component : AComponent
    {
        public override void Operate()
        {
            Console.WriteLine("原始类");
        }
    }
}
