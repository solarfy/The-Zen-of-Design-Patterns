using System;

namespace ZenOfDesignPattern.State_Pattern
{
    //具体状态角色；本状态的行为管理以及趋向状态处理（本状态下要做的事，以及本状态如何过度到其他状态）
    class ConcreteState1 : AbsState
    {
        public override void Handle1()
        {
            Console.WriteLine("State1状态下处理Handle1逻辑，完成后切换到State2");
            base.context.SetCurrentState(Context.State2);
        }

        public override void Handle2()
        {
            Console.WriteLine("State1状态下处理Handle2逻辑，完成后状态保持不变");
        }

        public override void Handle3()
        {
            Console.WriteLine("State1状态下处理Handle3逻辑，完成后状态切换到State3");
            base.context.SetCurrentState(Context.State3);
        }
    }
}
