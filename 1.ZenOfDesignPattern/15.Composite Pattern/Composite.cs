using System;
using System.Collections.Generic;

namespace ZenOfDesignPattern.Composite_Pattern
{
    //树枝构件
    class Composite : AComponent
    {
        //存储树枝构件或叶子构件的容器
        private List<AComponent> components = new() { };

        //新增一个树枝构件或叶子构件
        public void Add(AComponent cmp)
        {
            this.components.Add(cmp);
            cmp.SetParent(this);    //自身为父节点
        }

        //删除一个树枝构件或叶子构件
        public void Remove(AComponent cmp)
        {
            this.components.Remove(cmp);
        }

        //获取分支下的所有树枝构件和叶子构件
        public List<AComponent> GetChildren()
        {
            return components;
        }

        public override void DoSomething()
        {
            Console.WriteLine($"树枝构件{Name}执行业务逻辑，它的父节点是{GetParent()?.Name}");
        }
    }
}
