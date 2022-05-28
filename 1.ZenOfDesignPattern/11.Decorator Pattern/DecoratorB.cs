using System;

namespace ZenOfDesignPattern.Decorator_Pattern
{
    public class DecoratorB : ADecorator
    {
        public DecoratorB(AComponent _component) : base(_component)
        {

        }

        public override void Operate()
        {
            base.Operate();
            Console.WriteLine("装饰类B");
        }
    }
}
