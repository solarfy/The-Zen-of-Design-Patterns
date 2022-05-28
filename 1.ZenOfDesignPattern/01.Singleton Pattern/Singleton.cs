using System;

namespace ZenOfDesignPattern.Singleton_Pattern
{
    /* 单列模式 确保某一个类只有一个实例，而且自行实例化该类，并向整个系统提供这个实例。     
     */
    class Singleton
    {

        private static Singleton singleton = new Singleton();

        //private 限制产生多个实例
        private Singleton()
        {

        }

        //通过该方法获得实例
        public static Singleton GetSingleton()
        {
            //高并发的情况下不推荐使用该方案，推荐在声明的时候实例化该对象
            //if (singleton == null)
            //    singleton = new Singleton();

            return singleton;
        }
      
        public void DoSomething()
        {
            Console.WriteLine("单例模式：do something");
        }
        
    }
}
