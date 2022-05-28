namespace ZenOfDesignPattern.State_Pattern
{
    //抽象状态角色；接口或抽象类，负责对状态定义，并且封装环境角色以实现状态的自由切换
    abstract class AbsState
    {
        //定义一个环境角色（状态机），提供子类访问
        protected Context context;

        //设置环境角色
        public void SetContext(Context context)
        {
            this.context = context;
        }

        //行为
        public abstract void Handle1();
        public abstract void Handle2();
        public abstract void Handle3();
    }
}
