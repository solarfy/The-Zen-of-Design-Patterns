using System;
using System.Reflection;

namespace ZenOfDesignPattern.Factory_Method
{
    //具体工厂类
    class Creator : AbstractCreator
    {
        public override T CreateProduct<T>()
        {
            AbstractProduct product = null;

            ConstructorInfo info = typeof(T).GetConstructor(Array.Empty<Type>());  //利用反射获取一个公共无参构造函数     
            if (info != null)
                product = (T)info.Invoke(null);
                
            return (T)product;
        }

        //工厂模式的扩展应用
        //简单工厂模式：一个模块仅需一个工厂类，没必要new出来，可省去抽象工厂，使用静态方法。
        //多个工厂类：每个产品都有一个独立的工厂。
        //替代单例模式：即该工厂有且仅有一个产品。
        //延迟初始化：通过定义一个容器，容纳所有的产品，如果容器中已有的对象，则直接取回，如果没有则产生一个对象并放入容器中，以便下次使用。
    }
}
