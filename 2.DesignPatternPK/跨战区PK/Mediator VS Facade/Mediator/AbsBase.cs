namespace DesignPatternPK.Mediator_VS_Facade.Mediator
{
    //抽象基础类
    abstract class AbsBase
    {
        protected AbsMediator mediator;

        public AbsBase(AbsMediator _mediator) => mediator = _mediator;
    }
}
