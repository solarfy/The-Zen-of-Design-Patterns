using System;
using System.Collections.Generic;

namespace ZenOfDesignPattern.Observer_Pattern
{
    //具体被观察者；IObservale<T> C#中自带被观察者接口   
    class ConcreteSubjcet : IObservable<string>
    {
        //通过委托实现通知
        public Action<string> NotifyAction;        

        //定义存储观察者的容器
        private List<IObserver<string>> observers = new() { };  

        //订阅-新增观察者。不同于常规实现，它具有一个IDisposable的返回值，当观察者不再接收通知时，可通过Dispose函数取消订阅。
        public IDisposable Subscribe(IObserver<string> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new UnSubscriber<string>(observers, observer);
        }

        //取消订阅
        public void UnSubscribe(IObserver<string> observer)
        {
            new UnSubscriber<string>(observers, observer).Dispose();
        }

        //取消订阅通过IDisposable的Dispose方法；所以此处定义该类
        private class UnSubscriber<T> : IDisposable
        {
            private List<IObserver<T>> observers;
            IObserver<T> observer;

            public UnSubscriber(List<IObserver<T>> _observers, IObserver<T> _observer)
            {
                this.observers = _observers;
                this.observer = _observer;
            }

            public void Dispose()
            {
                if (observers != null && observers.Contains(observer))
                    observers.Remove(observer);
            }
        }
        
        //通知所有的观察者
        private void Notify(string value)
        {
            foreach (var observer in observers)
            {
                try
                {
                    observer.OnNext(value);
                    observer.OnCompleted();
                }
                catch (Exception exc)
                {
                    observer.OnError(exc);
                }
            }
        }

        public void Cold()
        {
            Console.WriteLine("降温");
            Notify("天气变凉");            
        }

        public void Heat()
        {
            Console.WriteLine("升温");
            Notify("天气变热");
        }

        //通过委托实现通知
        public void Cool()
        {
            Console.WriteLine("舒适");
            NotifyAction("天气凉爽");
        }
    }
}
