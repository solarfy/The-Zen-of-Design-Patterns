using System.Collections.Generic;

namespace ZenOfDesignPattern.Flyweight_Pattern
{
    //享元工厂；构造一个容器，同时提供从池中获得对象的方法
    class FlyweightFactory
    {
        //定义一个容器
        private static Dictionary<string, AbsFlyweight> pool = new Dictionary<string, AbsFlyweight>();
        //实例个数
        public static int InstanceCount { get => pool.Count; }

        //创建实例
        public static AbsFlyweight CreateFlyweight(string key)
        {
            if (!pool.ContainsKey(key))
                pool.Add(key, new Flyweight());

            return pool[key];
        }
    }
}
