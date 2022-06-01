using System;

namespace MixedMode.Observer_Mediator
{
    //抽象的事件处理者
    abstract class AbsEventCustomer
    {
        //定义事件处理者能够处理的级别
        public EventCustomerType CustomType { get; set; }

        //处理者所需处理的事件
        public abstract void Exec(ProductEvent productEvent);
    }

    //乞丐
    class Beggar : AbsEventCustomer
    {
        public Beggar()
        {
            base.CustomType = EventCustomerType.DEL;
        }

        public override void Exec(ProductEvent productEvent)
        {
            //事件源头
            Product p = productEvent.GetSource();
            //事件类型
            ProductEventType t = productEvent.GetEventType();

            Console.WriteLine($"乞丐处理事件：{p} 销毁，事件类型{t}");
        }
    }

    //平民
    class Commoner : AbsEventCustomer
    {
        public Commoner()
        {
            base.CustomType = EventCustomerType.NEW;
        }

        public override void Exec(ProductEvent productEvent)
        {
            //事件源头
            Product p = productEvent.GetSource();
            //事件类型
            ProductEventType t = productEvent.GetEventType();

            Console.WriteLine($"平民处理事件：{p} 诞生记，事件类型{t}");
        }
    }

    //贵族
    class Nobleman : AbsEventCustomer
    {
        public Nobleman()
        {
            base.CustomType = EventCustomerType.EDIT | EventCustomerType.CLONE | EventCustomerType.NEW | EventCustomerType.DEL;
        }

        public override void Exec(ProductEvent productEvent)
        {
            //事件源头
            Product p = productEvent.GetSource();
            //事件类型
            ProductEventType t = productEvent.GetEventType();

            if (t == ProductEventType.CLONE_PRODUCT)
                Console.WriteLine($"贵族处理事件：{p} 克隆，事件类型{t}");
            else if (t == ProductEventType.EDIT_PRODUCT)
                Console.WriteLine($"贵族处理事件：{p} 修改，事件类型{t}");
            else if (t == ProductEventType.DEL_PRODUCT)
                Console.WriteLine($"贵族处理事件：{p} 销毁，事件类型{t}");
            else if (t == ProductEventType.NEW_PRODUCT)
                Console.WriteLine($"贵族处理事件：{p} 诞生记，事件类型{t}");
        }
    }
}
