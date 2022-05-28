namespace ZenOfDesignPattern.Builder_Pattern
{
    //抽象建造者
    abstract class AbstractBuilder
    {
        //设置产品的不同部分，以获得不同的产品（产品的组装）
        public abstract void SetPart();

        //建造产品
        public abstract Product BuildProduct();
    }
}
