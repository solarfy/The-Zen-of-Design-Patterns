namespace DesignPatternPK.Packaging_mode_group.Agent
{
    //经纪人
    class Agent : IStar
    {
        private IStar star;

        //哪个明星的经纪人
        public Agent(IStar star) => this.star = star;

        //经纪人不签字，由明星签字
        public void Sign()
        {
            star.Sign();
        }
    }
}
