namespace ZenOfDesignPattern.Strategy_Pattern
{
    //封装角色；也称上下文角色，起承上启下封装作用，屏蔽高层模块对策略，算法的直接访问，封装可能存在的变化。
    class Context
    {
        //抽象策略
        private IStrategy strategy = null;

        //通过构造函数设置具体策略
        public Context(IStrategy _strategy)
        {
            this.strategy = _strategy;
        }

        //执行策略
        public void DoStrategy()
        {
            this.strategy.DoSomething();
        }
    }
}
