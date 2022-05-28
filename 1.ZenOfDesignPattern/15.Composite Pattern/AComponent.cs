using System;

namespace ZenOfDesignPattern.Composite_Pattern
{
    //抽象构件
    abstract class AComponent
    {
        AComponent parent = null;

        public string Name { get; set; }

        public void SetParent(AComponent _parent) => this.parent = _parent;

        public AComponent GetParent() => this.parent;

        //个体和整体都具有的共享
        public virtual void DoSomething()
        {
            Console.WriteLine($"{Name}执行业务逻辑，它的父节点是{parent?.Name}");
        }
    }
}
