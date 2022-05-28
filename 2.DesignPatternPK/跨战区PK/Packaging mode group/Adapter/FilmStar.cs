namespace DesignPatternPK.Packaging_mode_group.Adapter
{
    //电影明星
    class FilmStar : IStar
    {
        public void Act(string context)
        {
            System.Console.WriteLine($"明星演戏：{context}");
        }
    }
}
