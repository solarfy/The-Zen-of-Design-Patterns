using System;

namespace ZenOfDesignPattern.Proxy_Pattern
{
    //强制代理；必须通过真实角色查找到代理角色，再通过代理访问其他。

    interface ISubjectCompel
    {
        public void Request();

        public ISubjectCompel GetProxy();
    }

    //真实代理类
    class SubjectCompel : ISubjectCompel
    {
        ISubjectCompel proxy = null;

        //检验是否是代理访问
        bool IsProxy { get => proxy != null; }

        //获取指定的代理
        public ISubjectCompel GetProxy()
        {
            return proxy ??= new Proxy_Compel(this);    
        }

        public void Request()
        {
            if (IsProxy)
                Console.WriteLine("真实业务逻辑");
            else
                Console.WriteLine("请使用指定的代理类访问");
        }
    }

    //强制代理类
    class Proxy_Compel : ISubjectCompel
    {
        ISubjectCompel subject = null;

        public Proxy_Compel(ISubjectCompel subject)
        {
            this.subject = subject;
        }

        //代理的代理暂时没有，就是自己
        public ISubjectCompel GetProxy()
        {
            return this;
        }

        public void Request()
        {
            subject?.Request();
        }
    }
}
