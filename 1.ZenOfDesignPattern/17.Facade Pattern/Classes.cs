using System;

namespace ZenOfDesignPattern.Facade_Pattern
{
    //几个独立的类

    class ClassA
    {
        public void DoSomethingA()
        {
            Console.WriteLine("ClassA 执行业务逻辑");
        }
    }

    class ClassB
    {
        public void DoSomethingB()
        {
            Console.WriteLine("ClassB 执行业务逻辑");
        }
    }

    class ClassC
    {
        public void DoSomethingC()
        {
            Console.WriteLine("ClassC 执行业务逻辑");
        }
    }
}
