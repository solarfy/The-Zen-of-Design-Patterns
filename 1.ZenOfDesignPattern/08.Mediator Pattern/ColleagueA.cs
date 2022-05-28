using System;

namespace ZenOfDesignPattern.Mediator_Pattern
{
    public class ColleagueA : AbstractColleague
    {
        public ColleagueA(AbstractMediator mediator) : base(mediator)
        {
            
        }

        //自己独有的方法
        public void SelfMethod()
        {
            Console.WriteLine("ColleagueA处理自己的业务");
        }

        //自己不能处理的业务，委托中介者处理
        public void DepMethod()
        {
            Console.WriteLine("ColleagueA处理业务");
            base.mediator.DoSomething();
        }
    }
}
