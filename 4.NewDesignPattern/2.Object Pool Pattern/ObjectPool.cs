using System;
using System.Collections.Generic;

namespace NewDesignPattern.Object_Pool_Pattern
{
    abstract class ObjectPool<T> where T : new()
    {
        private readonly Stack<T> pool = new() { };

        //最大对象个数
        public int MaxCount { get; set; } = 100;

        //池中对象总数
        public int CountAll { get; private set; }
        //池中现有的对象个数（不处于工作状态下的对象）
        public int CountInactive { get => pool.Count; }
        //池中活跃的对象个数 （处于工作状态下的对象，不在池中）
        public int CountActive { get => CountAll - CountInactive; }

        //创建对象时执行的委托
        private Action<T> ObjectOnCreate;
        //回收对象时执行的委托
        private Action<T> ObjectOnRelease;

        public ObjectPool(Action<T> createAction, Action<T> releaseAction)
        {
            ObjectOnCreate = createAction;
            ObjectOnRelease = releaseAction;
        }

        //创建对象
        public T CreateObject()
        {
            T element;

            if (CountInactive == 0)
            {
                if (CountAll > MaxCount)
                    throw new Exception($"对象个数已达上限（{MaxCount}）");

                element = new T();
                CountAll++;
            }
            else
            {
                element = pool.Pop();
            }

            ObjectOnCreate?.Invoke(element);

            return element;
        }
      
        //回收对象
        public void ReleaseObject(T element)
        {
            if (CountInactive > 0 && ReferenceEquals(pool.Peek(), element))
            {
                throw new Exception("正在尝试销毁已存放在池中的对象");
            }

            ObjectOnRelease?.Invoke(element);

            pool.Push(element);
        }
    }
}
