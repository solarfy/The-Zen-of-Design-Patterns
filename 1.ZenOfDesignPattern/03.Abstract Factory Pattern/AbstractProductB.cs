using System;

namespace ZenOfDesignPattern.Abstract_Factory_Pattern
{
    //抽象产品B
    abstract class AbstractProductB
    {

        public void ShareMethod()
        {
            Console.WriteLine("产品B共有的方法");
        }

        //产品B相同的方法，不同的实现
        public abstract void DoSomething();
    }
}
