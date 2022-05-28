using System;

namespace ZenOfDesignPattern.Observer_Pattern
{
    //具体观察者；IObserver<T> C#中自带接口 
    //T 通知的数据类型，实际开发中应写具体类型
    class ConcreteObserver : IObserver<string>
    {
        public string Name { get; set; }

        public ConcreteObserver(string name) => Name = name;

        //通知观察者，提供程序已完成发送基于推送的通知
        public void OnCompleted()
        {
            Console.WriteLine($"已完成向{Name}发送的通知");
        }

        //通知观察者，提供程序遇到错误的情况
        public void OnError(Exception error)
        {
            Console.WriteLine($"通知出错：{error.Message}");
        }

        //向观察者提供新数据
        public void OnNext(string value)
        {
            Console.WriteLine($"{Name}收到通知{value.ToString()}");
        }
    }
}
