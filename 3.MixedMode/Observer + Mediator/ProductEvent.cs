using System;

namespace MixedMode.Observer_Mediator
{
    //产品事件
    class ProductEvent : IObservable<ProductEvent>
    {
        //事件起源
        private Product source;
        //事件类型
        private ProductEventType type;
            
        public ProductEvent(Product _p, ProductEventType _type)
        {
            source = _p;
            type = _type;
                    
            IObservable<ProductEvent> iobserver = this;  //显示接口只能通过接口的实例进行调用
            iobserver.Subscribe(EventDispatch.GetEventDispatch());      //该类事件只有一个订阅者：EventDispatch；再由该订阅者分发事件        
        }
   
        //获取事件源
        public Product GetSource() => source;

        //获得事件的类型
        public ProductEventType GetEventType() => type;     
        
        //事件订阅（此处用显示接口表示，不对外暴露订阅方法）
        IDisposable IObservable<ProductEvent>.Subscribe(IObserver<ProductEvent> observer)
        {            
            observer.OnNext(this);    //触发事件
            return new Unsubscribe<ProductEvent>(observer);
        }

        //取消订阅类
        private class Unsubscribe<T> : IDisposable
        {
            IObserver<T> observer;
           
            public Unsubscribe(IObserver<T> _observer)
            {
                observer = _observer;
            }

            public void Dispose()
            {
                observer = null;   
            }
        }
    }
}
