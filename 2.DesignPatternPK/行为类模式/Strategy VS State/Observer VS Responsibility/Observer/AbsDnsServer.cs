using System;
using Recorder = DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility.Recorder;
using Tools = DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Responsibility.Tools;

namespace DesignPatternPK.Strategy_VS_State.Observer_VS_Responsibility.Observer
{
    //抽象的DNS服务器；既是一个观察者也是一个被观察者
    abstract class AbsDnsServer : IObserver<Recorder>, IObservable<Recorder>
    {
        //上级服务器
        private AbsDnsServer upperServer;

        //每个DNS服务器上签上自己的名字
        protected abstract void Sign(Recorder recorder);

        //每个DNS服务器都必须定义自己的处理逻辑
        protected abstract bool IsLocal(Recorder recorder);

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        //处理请求，也就是接收到事件后的处理
        public void OnNext(Recorder value)
        {
            //如果是本服务器能够解析的，则本服务器解析；如果本服务器不能解析，则交由上级服务器解析。
            if (IsLocal(value))
            {                
                value.SetIp(Tools.CreateIpAddress());
            }
            else
            {
                upperServer.OnNext(value);
            }

            Sign(value); //签名
        }

        //订阅；设置上级服务器（此处只有一个上级，所以只有一个观察者）
        public IDisposable Subscribe(IObserver<Recorder> server)
        {
            upperServer = (AbsDnsServer)server;
            return new UnSubscribe<Recorder>(server);
        }

        //取消订阅类
        class UnSubscribe<T> : IDisposable
        {
            private IObserver<T> observer;

            public UnSubscribe(IObserver<T> _observer) => observer = _observer;

            public void Dispose()
            {
                observer = null;
            }
        }
    }
}
