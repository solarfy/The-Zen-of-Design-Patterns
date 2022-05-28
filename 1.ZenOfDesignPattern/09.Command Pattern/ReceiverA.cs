using System;

namespace ZenOfDesignPattern.Command_Pattern
{
    public class ReceiverA : AbstractReceiver
    {
        public override void DoSomething()
        {
            Console.WriteLine("ReveiverA 执行业务");
        }

        public override void RollBack()
        {
            Console.WriteLine("ReveiverA 命令回滚");
        }
    }
}
