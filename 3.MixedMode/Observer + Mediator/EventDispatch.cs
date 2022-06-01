using System;
using System.Collections.Generic;

namespace MixedMode.Observer_Mediator
{
    //事件观察者（事件分发者）（中介者模式）--由被分发者执行具体任务
    class EventDispatch : IObserver<ProductEvent>
    {
        //单例模式
        private static EventDispatch dispatch = new();

        //实际事件处理者
        private List<AbsEventCustomer> customers = new();

        //private构造函数，不允许产生新的实例
        private EventDispatch()
        {

        }
        public static EventDispatch GetEventDispatch() => dispatch;

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(ProductEvent value)
        {
            //遍历所有的事件处理者，根据处理权限，分发事件
            foreach (AbsEventCustomer customer in customers)
            {
                if (customer.CustomType.Contains(value.GetEventType()))
                {
                    customer.Exec(value);
                }
            }
        }

        //注册事件处理者
        public void RegisterCustomer(AbsEventCustomer customer)
        {
            customers.Add(customer);
        }

        //注销事件处理者
        public void UnregisterCusomter(AbsEventCustomer customer)
        {
            customers.Remove(customer);
        }
    }
}
