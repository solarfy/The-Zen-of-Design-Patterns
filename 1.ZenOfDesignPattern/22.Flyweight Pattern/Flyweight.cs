using System;

namespace ZenOfDesignPattern.Flyweight_Pattern
{
    //具体享元角色
    class Flyweight : AbsFlyweight
    {
        public override void DoSomething(string context)
        {
            Console.WriteLine($"Flyweight operate {context}");
        }
    }
}
