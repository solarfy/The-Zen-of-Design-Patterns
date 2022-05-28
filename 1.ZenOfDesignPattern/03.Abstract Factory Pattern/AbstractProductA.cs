using System;

namespace ZenOfDesignPattern.Abstract_Factory_Pattern
{
    //抽象产品A
    abstract class AbstractProductA
    {
        public void ShareMethod()
        {
            Console.WriteLine("产品A共有的方法");
        }

        //产品A相同的方法，不同的实现
        public abstract void DoSomething();
    }
}
