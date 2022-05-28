using System;

namespace ZenOfDesignPattern.Adapter_Pattern
{
    //具体的目标角色
    class Target : ITarget
    {
        public void Request()
        {
            Console.WriteLine("目标角色特有的业务逻辑");
        }
    }
}
