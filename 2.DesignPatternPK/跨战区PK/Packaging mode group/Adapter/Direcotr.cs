namespace DesignPatternPK.Packaging_mode_group.Adapter
{
    //导演类
    class Direcotr
    {
        //表演开始
        public void Play()
        {
            //定义一个电影明星
            IStar filmStar = new FilmStar();
            filmStar.Act("前十五分钟，明星本人演戏");
            //定义一个普通演员
            IActor actor = new UnknowActor();
            //通过适配器将普通演员IActor转变为明星IStar
            IStar stanin = new Standin(actor);
            stanin.Act("中间五分钟，替身演戏");
            filmStar.Act("后十五分钟，明星本人演戏");
        }
    }
}
