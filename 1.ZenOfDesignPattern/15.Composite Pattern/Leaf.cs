using System;

namespace ZenOfDesignPattern.Composite_Pattern
{
    //叶子构件 [此处为安全模式，若采用透明模式则叶子节点与树枝节点将实现同样的接口，可将不能使用的接口标记为Obsolete废弃方法]
    class Leaf : AComponent
    {
        public override void DoSomething()
        {
           Console.WriteLine($"叶子构件{Name}执行业务逻辑，它的父节点是{GetParent()?.Name}");
        }
    }
}
