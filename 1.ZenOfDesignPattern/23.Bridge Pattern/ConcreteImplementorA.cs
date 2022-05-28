using System;

namespace ZenOfDesignPattern.Bridge_Pattern
{
    //具体实现化角色A
    class ConcreteImplementorA : Implementor
    {
        public void DoAnything()
        {
            Console.WriteLine("ConcreteImplementorA DoAnything");
        }

        public void DoSomething()
        {
            Console.WriteLine("ConcreteImplementorA DoSomething");
        }
    }
}
