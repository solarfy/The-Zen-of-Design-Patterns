namespace ZenOfDesignPattern.Abstract_Factory_Pattern
{
    //抽象工厂类
    abstract class AbstractCreator
    {
        //创建产品A
        public abstract AbstractProductA CreateProductA();

        //创建产品B
        public abstract AbstractProductB CreateProductB();
    }
}
