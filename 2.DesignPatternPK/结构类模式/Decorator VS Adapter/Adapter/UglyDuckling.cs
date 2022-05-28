namespace DesignPatternPK.Decorator_VS_Adapter.Adapter
{
    //丑小鸭类；将白天鹅当作鸭子对待
    class UglyDuckling : WhiteSwan, IDuck
    {
        //注释掉会调用WhiteSwan中的Cry方法
        //void IDuck.Cry()
        //{
        //    System.Console.WriteLine("IDuck的Cry()");
        //    base.Cry();
        //}

        public void Appearance()
        {
            base.Appaearance();
        }

        public void Behavior()
        {
            System.Console.WriteLine("会游泳");
            base.Fly();
        }
    }
}
