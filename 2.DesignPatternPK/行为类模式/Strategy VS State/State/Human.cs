namespace DesignPatternPK.Strategy_VS_State.State
{
    class Human
    {
        //定义人类所具有的状态
        public static AbsHumanState CHILD_STATE = new ChildState();
        public static AbsHumanState ADULT_STATE = new AdultState();
        public static AbsHumanState OLD_STATE = new OldState();

        private AbsHumanState humanState;

        //设置一个状态
        public void SetState(AbsHumanState state)
        {
            //state与human相互关联
            humanState = state;
            state.SetHuamn(this);   
        }

        //人类的工作
        public void Work()
        {
            humanState.Work();
        }
    }
}
