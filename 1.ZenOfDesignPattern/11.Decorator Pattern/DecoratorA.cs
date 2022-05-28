using System;

namespace ZenOfDesignPattern.Decorator_Pattern
{
    //具体装饰类；将最核心，最原始，最基本的东西装饰成其他东西。
    public class DecoratorA : ADecorator
    {
        public DecoratorA(AComponent _component) : base(_component)
        {

        }

        public override void Operate()
        {
            Console.WriteLine("----------");
            base.Operate();
            Console.WriteLine("装饰类A");
        }
    }
}
