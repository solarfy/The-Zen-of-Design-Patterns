using System;

namespace DesignPatternPK.Strategy_VS_State.State
{
    class ChildState : AbsHumanState
    {
        public override void Work()
        {
            Console.WriteLine("儿童的工作就是玩耍！");
            base.human.SetState(Human.ADULT_STATE);     //自动切换到成年人
        }
    }

    class AdultState : AbsHumanState
    {
        public override void Work()
        {
            Console.WriteLine("成年人的工作就是先养活自己，然后为社会做贡献！");
            base.human.SetState(Human.OLD_STATE);       //自动切换到老年人
        }
    }

    class OldState : AbsHumanState
    {
        public override void Work()
        {
            Console.WriteLine("老年人的工作就是享受天伦之乐！");
        }
    }
}
