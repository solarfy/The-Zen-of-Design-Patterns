using System;
using System.Collections.Generic;

namespace ZenOfDesignPattern.Singleton_Pattern
{
    //固定数量的单例模式
    class SingletonMultiple
    {
        //单例的固定数量
        private static int maxNumOfInstance = 2;
        //定义一个列表，容纳所有的实例
        private static List<SingletonMultiple> instances = new List<SingletonMultiple> { };
        //当前实列的序号
        private static int countNumOfInstance = 0;
        
        //private 限制外部产生实例
        private SingletonMultiple()
        {

        }

        //静态构造函数
        static SingletonMultiple()
        {
            for (int i = 0; i < maxNumOfInstance; i++)
                instances.Add(new SingletonMultiple());
        }

        //通过该方法获得实例
        public static SingletonMultiple GetInstance()
        {
            Random random = new Random();

            countNumOfInstance = random.Next(maxNumOfInstance);

            return instances[countNumOfInstance];

        }

        public void DoSomething()
        {
            Console.WriteLine($"固定单例数量模式 索引{countNumOfInstance}：do something");
        }

    }
}
