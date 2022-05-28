namespace DesignPatternPK.Packaging_mode_group.Bridge
{
    //歌手
    class Singer : AbsStar
    {
        //歌手的主要工作是唱歌
        public Singer() : base(new Sing())
        {

        }

        //也可以重写设置一个新的职业
        public Singer(AbsAction action) : base(action)
        {

        }


        public override void DoJob()
        {
            System.Console.WriteLine("歌手的主要工作是：");
            base.DoJob();
        }
    }
}
