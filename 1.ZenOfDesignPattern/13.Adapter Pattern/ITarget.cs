namespace ZenOfDesignPattern.Adapter_Pattern
{
    /* 适配器模式
     * 将一个类的接口变成客户端所期待的另一种接口，从而使两个不匹配的类能够一起工作。
     */

    //目标角色；将其它类转换为何种接口，即期望的接口。
    public interface ITarget
    {
        //
        void Request();
    }
}
