using System;

namespace ZenOfDesignPattern.Chain_of_Responsibility
{
    public class Handle3 : AHandle
    {
        public Handle3()
        {
            base.Level = Levels.General;
        }

        public override void DoSomething(Request request)
        {
            Console.WriteLine($"Handle3的等级是{base.Level}，处理的请求是{request.Content}");
        }
    }
}
