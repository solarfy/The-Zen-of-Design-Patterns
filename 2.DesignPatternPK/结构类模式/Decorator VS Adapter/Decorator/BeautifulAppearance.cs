namespace DesignPatternPK.Decorator_VS_Adapter.Decorator
{
    //外形美化
    class BeautifulAppearance : AbsDecorator
    {
        public BeautifulAppearance(ISwan _swan) : base(_swan)
        {

        }

        public override void Appaearance()
        {
            System.Console.WriteLine("外形是纯白色的，非常惹人喜爱");
        }
    }
}
