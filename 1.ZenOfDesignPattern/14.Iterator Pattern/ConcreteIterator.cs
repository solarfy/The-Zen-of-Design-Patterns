namespace ZenOfDesignPattern.Iterator_Pattern
{

    //具体迭代器 （C#中 IEnumerator现成的迭代器）
    class ConcreteIterator : Iterator
    {
        //定义一个容器
        private ConcreteAggregate aggregate;
        private int current = 0;

        //通过构造器，注入具体的容器
        public ConcreteIterator(ConcreteAggregate _aggregate)
        {
            this.aggregate = _aggregate;
        }

        public object CurrentItem()
        {
            return aggregate[current];
        }

        public object First()
        {
            return aggregate[0];
        }

        public bool IsDone()
        {
            return !(current < aggregate.Count);
        }

        public object Next()
        {
            current++;
            object ret = null;

            if (!IsDone())
            {
                ret = aggregate[current];
            }

            return ret;
        }
    }
}
