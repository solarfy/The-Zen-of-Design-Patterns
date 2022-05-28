namespace ZenOfDesignPattern.Iterator_Pattern
{
    //抽象迭代器
    interface Iterator
    {
        //首个元素
        object First();
        //下一个元素
        object Next();
        //是否到结尾
        bool IsDone();
        //当前对象
        object CurrentItem();
    }
}
