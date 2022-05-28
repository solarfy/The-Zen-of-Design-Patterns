namespace DesignPatternPK.Packaging_mode_group.Bridge
{
    //电影明星
    class FilmStar : AbsStar
    {
        //电影明星默认的主要工作是拍电影
        public FilmStar() : base(new ActFilm())
        {
            
        }

        //也可以重写设置一个新的职业
        public FilmStar(AbsAction action) : base(action)
        {

        }

        public override void DoJob()
        {
            System.Console.WriteLine("电影明星的工作：");
            base.DoJob();
        }

    }
}
