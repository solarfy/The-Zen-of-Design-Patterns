namespace DesignPatternPK.Packaging_mode_group.Adapter
{
    //替身演员
    class Standin : IStar
    {
        //替身演员本质是一个普通演员
        private IActor actor;

        public Standin(IActor actor) => this.actor = actor;

        public void Act(string context)
        {
            actor.Playact(context);
        }
    }
}
