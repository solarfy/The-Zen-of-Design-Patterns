using System;

namespace ZenOfDesignPattern.Chain_of_Responsibility
{
    public class Handle4 : AHandle
    {
        public Handle4()
        {
            base.Level = Levels.Guest;
        }

        public override void DoSomething(Request request)
        {
            Console.WriteLine($"Handle4的等级是{base.Level}，处理的请求是{request.Content}");
        }
    }
}
