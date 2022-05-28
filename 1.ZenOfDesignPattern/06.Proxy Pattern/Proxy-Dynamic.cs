using Castle.DynamicProxy;
using System;

namespace ZenOfDesignPattern.Proxy_Pattern
{
    /* 动态代理。Java里面有JDK和CGLIB代理。C#里面则使用Castle代理。
     * Nuget安装Castle.Core
     */

    interface ISubjectDynamic
    {
        string Request(string msg);
    }

    //真实主题类
    public class RealSubject : ISubjectDynamic
    {
        //注意 Request必须是否虚方法，否则将不会进入Intercept方法
        public virtual string Request(string msg)
        {
            Console.WriteLine($"RealSubject收到内容{msg}");
            return msg;
        }
    }

    //创建拦截器-主要对方法进行拦截处理
    public class SubjectInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            //执行的方法为需方法，否则将不会进入此次
            Console.WriteLine("进入方法，参数:" + invocation.Arguments[0].ToString());
            invocation.Proceed();
            Console.WriteLine("离开方法，返回值:" + invocation.ReturnValue);
        }
    }

    //动态代理
    class Proxy_Dynamic
    {
        public static T CreateLandlordProxy<T>() where T : class
        {
            ProxyGenerator proxyGenerator = new ProxyGenerator();
            T proyLandlord = proxyGenerator.CreateClassProxy<T>(new SubjectInterceptor());
            return proyLandlord;
        }    
    }
}
