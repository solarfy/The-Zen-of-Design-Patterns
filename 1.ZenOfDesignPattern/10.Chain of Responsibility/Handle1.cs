using System;

namespace ZenOfDesignPattern.Chain_of_Responsibility
{
    public class Handle1 : AHandle
    {
        public Handle1()
        {
            base.Level = Levels.Developer;
        }

        public override void DoSomething(Request request)
        {
            Console.WriteLine($"Handle1的等级是{base.Level}，处理的请求是{request.Content}");
        }
    }
}
