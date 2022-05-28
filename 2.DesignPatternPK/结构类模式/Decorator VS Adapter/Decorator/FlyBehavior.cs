namespace DesignPatternPK.Decorator_VS_Adapter.Decorator
{
    //行为突破，不会飞行变成会飞行的
    class FlyBehavior : AbsDecorator
    {
        public FlyBehavior(ISwan _swan) : base(_swan)
        {

        }

        public override void Fly()
        {
            System.Console.WriteLine("会飞行了");
        }
    }
}
