namespace ZenOfDesignPattern.Mediator_Pattern
{
    //抽象同事类
    public abstract class AbstractColleague
    {
        protected AbstractMediator mediator;

        //通过构造函数注入中介者（同事类必须有中介者，而中介者却可以只有部分同事类）
        public AbstractColleague(AbstractMediator _mediator)
        {
            this.mediator = _mediator;
        }
    }
}
