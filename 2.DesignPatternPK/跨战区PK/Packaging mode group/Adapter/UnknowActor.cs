namespace DesignPatternPK.Packaging_mode_group.Adapter
{
    //普通演员
    class UnknowActor : IActor
    {
        public void Playact(string context)
        {
            System.Console.WriteLine($"普通演员：{context}");
        }
    }
}
