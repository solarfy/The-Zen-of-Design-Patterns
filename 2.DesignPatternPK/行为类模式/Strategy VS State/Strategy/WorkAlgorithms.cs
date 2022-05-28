using System;

namespace DesignPatternPK.Strategy_VS_State.Strategy
{
    class ChildWork : AbsWorkAlgorithm
    {
        public override void Work()
        {
            Console.WriteLine("儿童的工作是玩耍！");
        }
    }

    class AdultWork : AbsWorkAlgorithm
    {
        public override void Work()
        {
            Console.WriteLine("成年人的工作就是先养活自己，然后为社会做贡献！");
        }
    }

    class OldWork : AbsWorkAlgorithm
    {
        public override void Work()
        {
            Console.WriteLine("老年人的工作就是享受天伦之乐！");
        }
    }
}
