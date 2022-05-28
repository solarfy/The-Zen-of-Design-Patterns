namespace ZenOfDesignPattern.Factory_Method
{
    //抽象工厂类
    internal abstract class AbstractCreator
    {
        //创建一个产品对象
        public abstract T CreateProduct<T>() where T : AbstractProduct;
    }
}
