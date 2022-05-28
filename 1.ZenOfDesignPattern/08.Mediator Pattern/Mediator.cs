using System;

namespace ZenOfDesignPattern.Mediator_Pattern
{
    class Mediator : AbstractMediator
    {   
        public override void DoSomething()
        {
            Console.WriteLine("中介者介入，开始处理业务");
            base.ColleagueA.SelfMethod();
            base.ColleagueB.SelfMethod();
        }
    }
}
