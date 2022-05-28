namespace ZenOfDesignPattern.Flyweight_Pattern
{
    //抽象享元角色；定义出对象的外部状态和内部状态的接口或实现
    abstract class AbsFlyweight
    {
        public abstract void DoSomething(string context);
    }
}
