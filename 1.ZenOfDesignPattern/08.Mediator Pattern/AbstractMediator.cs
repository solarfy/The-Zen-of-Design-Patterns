namespace ZenOfDesignPattern.Mediator_Pattern
{
    //抽象中介者
    public abstract class AbstractMediator
    {

        //定义同事类（此处使用实际抽象类，因为实际使用中很少有相同的方法；如果同事类中有相同的方法，就可以使用抽象类）
        public ColleagueA ColleagueA { get; set; }
        public ColleagueB ColleagueB { get; set; }

        //中介者中业务处理，都是依赖同事类进行处理。

        public abstract void DoSomething();
    }
}
