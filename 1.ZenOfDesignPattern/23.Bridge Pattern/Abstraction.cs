namespace ZenOfDesignPattern.Bridge_Pattern
{
    //抽象化角色；一般为抽象类，定义出该角色的行为，同时保存一个对实现化角色的引用
    abstract class Abstraction
    {
        //定义对实现化角色的引用
        private Implementor implementor;

        //约束子类必须实现该构造函数
        public Abstraction(Implementor _implementor) => this.implementor = _implementor;

        //获得实现化角色
        public Implementor GetImplementor()
        {
            return this.implementor;
        }

        //自身的行为
        public void Request()
        {
            this.implementor.DoAnything();
            this.implementor.DoSomething();
        }
    }
}
