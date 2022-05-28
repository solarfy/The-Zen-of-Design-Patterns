namespace DesignPatternPK.Packaging_mode_group.Decorator
{
    class Deny : AbsDecorator
    {
        public Deny(IStar star) : base(star)
        {

        }

        public override void Act()
        {
            base.Act();
            System.Console.WriteLine("演后：百般抵赖，死不承认");
        }
    }
}
