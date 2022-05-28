namespace ZenOfDesignPattern.Iterator_Pattern
{
    //容器抽象类
    abstract class Aggregate
    {
        //创建迭代器
        public abstract Iterator CreateIterator();
    }
}
