namespace DesignPatternPK.Packaging_mode_group.Decorator
{
    //说大话
    class HotAir : AbsDecorator
    {
        public HotAir(IStar star) : base(star)
        {

        }

        public override void Act()
        {
            System.Console.WriteLine("演前：夸夸其谈，没有自己不能演的角色");

            base.Act();
        }
    }
}
