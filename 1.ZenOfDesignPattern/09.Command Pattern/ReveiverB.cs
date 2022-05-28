using System;

namespace ZenOfDesignPattern.Command_Pattern
{
    public class ReveiverB : AbstractReceiver
    {
        public override void DoSomething()
        {
            Console.WriteLine("ReveiverB 执行业务");
        }

        public override void RollBack()
        {
            Console.WriteLine("ReceiverB 命令回滚");
        }
    }
}
