namespace ZenOfDesignPattern.State_Pattern
{
    //环境角色，状态机；定义客户端需要的接口，并且负责具体状态的切换
    class Context
    {
        //定义状态
        public static AbsState State1 = new ConcreteState1();
        public static AbsState State2 = new ConcreteState2();
        public static AbsState State3 = new ConcreteState3();

        //当前状态
        private AbsState currentState;

        public AbsState GetCurrentState() => currentState;

        public void SetCurrentState(AbsState state)
        {
            currentState = state;
            currentState.SetContext(this);
        }

        public override string ToString()
        {
            string str = string.Empty;

            if (currentState is ConcreteState1)
                str = "State1";
            else if (currentState is ConcreteState2)
                str = "State2";
            else if (currentState is ConcreteState3)
                str = "State3";

            return str;
        }

        public void Handle1()
        {
            currentState.Handle1();
        }

        public void Handle2()
        {
            currentState.Handle2();
        }

        public void Handle3()
        {
            currentState.Handle3();
        }
    }
}
