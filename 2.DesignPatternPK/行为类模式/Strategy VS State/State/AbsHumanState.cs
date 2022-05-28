namespace DesignPatternPK.Strategy_VS_State.State
{
    abstract class AbsHumanState
    {
        //指向一个具体的人
        protected Human human;

        //设置一个具体的人
        public void SetHuamn(Human _human)
        {
            this.human = _human;
        }

        //不管什么状态，都需要工作
        public abstract void Work();
    }
}
