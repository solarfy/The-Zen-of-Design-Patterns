namespace ZenOfDesignPattern.Decorator_Pattern
{
    //抽象装饰类；实现接口或抽象类中的方法，它里面不一定有抽象方法，但必然有一个private变量指向AComponent抽象构件。
    public abstract class ADecorator : AComponent
    {
        private AComponent component = null;

        //通过构造函数传递被修饰者
        public ADecorator(AComponent _component) => this.component = _component;

        //委托给被修饰者执行
        public override void Operate()
        {
            this.component?.Operate();
        }
    }
}
