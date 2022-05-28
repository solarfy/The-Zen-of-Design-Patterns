using System;

namespace ZenOfDesignPattern.Proxy_Pattern
{
    /* 代理类；也称为委托类、代理类，它负责对真实角色的应用，并在真实主角处理完毕前后做预处理和善后处理工作。
     * 一个代理类可以代理多个被委托者。
     *  
     *  代理模式的扩展
     *  普通代理：客户端只能访问代理角色，而不能访问真实角色。
     *  强制代理：必须通过真实角色查找到代理角色，再通过代理访问其他。
     *  
    */
    class Proxy : ISubject
    {
        ISubject subject = null;

        public Proxy(ISubject subject)
        {
            if (null == subject)
                throw new NullReferenceException("无效的代理");

            this.subject = subject;
        }

        public void Request()
        {
            Before();
            subject.Request();
            After();
        }

        private void Before()
        {
            Console.WriteLine("代理类的预处理");
        }

        private void After()
        {
            Console.WriteLine("代理类的善后处理");
        }
    }
}
