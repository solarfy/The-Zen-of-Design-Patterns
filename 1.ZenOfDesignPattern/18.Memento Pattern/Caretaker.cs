using System.Collections.Generic;

namespace ZenOfDesignPattern.Memento_Pattern
{
    //备忘录管理员；管理、保存和提供备忘录
    class Caretaker
    {
        //容纳备忘录的容器
        private Dictionary<string, IMemento> mementos = new Dictionary<string, IMemento>() { };

        //获取备忘录 key：备忘录名称
        public IMemento GetMemento(string key)
        {
            return mementos[key];
        }

        //存储备忘录
        public void SetMemento(string key, IMemento memento)
        {
            mementos[key] = memento;
        }
    }
}
