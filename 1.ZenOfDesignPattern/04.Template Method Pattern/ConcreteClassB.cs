using System;

namespace ZenOfDesignPattern.Template_Method_Pattern
{
    class ConcreteClassB : AbstractClass
    {
        protected override void DoAnything()
        {
            Console.WriteLine("具体模板类B-DoAnything");
        }

        protected override void DoSomething()
        {
            Console.WriteLine("具体模板类B-DoSomething");
        }
    }
}
