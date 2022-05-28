using System;
using System.Collections.Generic;

namespace ZenOfDesignPattern.Iterator_Pattern
{
    //具体容器类
    class ConcreteAggregate : Aggregate
    {
        //存放聚合对象
        private IList<Object> items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count 
        {
            get => items.Count;
        }

        public object this[int index]
        {
            set => items.Insert(index, value);  //注意此处用的Insert。
            get => items[index];
        }     
    }
}
