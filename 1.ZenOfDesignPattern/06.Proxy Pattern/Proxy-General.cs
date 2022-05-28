namespace ZenOfDesignPattern.Proxy_Pattern
{
    //代理模式的扩展-普通代理
    class Proxy_General : ISubject
    {
        ISubject subject = null;

        public Proxy_General()
        {
            subject = new Subject();    //只能通过代理者创建对象
        }

        public void Request()
        {
            subject?.Request();
        }
    }
}
