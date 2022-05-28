namespace DesignPatternPK.Packaging_mode_group.Bridge
{
    //抽象明星
    abstract class AbsStar
    {
        //明星所参加的获得
        protected AbsAction action;

        //通过构造函数传递具体的活动
        public AbsStar(AbsAction action) => this.action = action;

        //活动的主要工作
        public virtual void DoJob()
        {
            action.Desc();
        }
    }
}
