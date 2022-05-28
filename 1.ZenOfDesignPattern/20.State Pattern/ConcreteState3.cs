using System;

namespace ZenOfDesignPattern.State_Pattern
{
    class ConcreteState3 : AbsState
    {
        public override void Handle1()
        {
            Console.WriteLine("State3状态下处理Handle1逻辑，完成后状态保持不变");
        }

        public override void Handle2()
        {
            Console.WriteLine("State3状态下处理Handle2逻辑，完成后状态保持不变");
        }
        
        public override void Handle3()
        {
            Console.WriteLine("State3状态下处理Handle3逻辑，完成后切换到State1");
            base.context.SetCurrentState(Context.State1);
        }
    }
}
