using System;

namespace ZenOfDesignPattern.Bridge_Pattern
{
    //具体实现化角色B
    class ConcreteImplementorB : Implementor
    {
        public void DoAnything()
        {
            Console.WriteLine("ConcreteImplementorB DoAnything");
        }

        public void DoSomething()
        {
            Console.WriteLine("ConcreteImplementorB DoSomething");
        }
    }
}
