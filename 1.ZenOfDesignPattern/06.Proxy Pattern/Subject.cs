using System;

namespace ZenOfDesignPattern.Proxy_Pattern
{
    //具体主题类；被委托、被代理的角色，业务逻辑具体执行者
    class Subject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("被代理类的业务逻辑处理 Request");
        }
    }
}
