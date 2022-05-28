using System;

namespace ZenOfDesignPattern.Chain_of_Responsibility
{
    public class Handle2 : AHandle
    {
        public Handle2()
        {
            base.Level = Levels.Admin;
        }

        public override void DoSomething(Request request)
        {
            Console.WriteLine($"Handle2的等级是{base.Level}，处理的请求是{request.Content}");
        }
    }
}
