namespace DesignPatternPK.Mediator_VS_Facade.Mediator
{
    class Tax : AbsBase, ITax
    {
        public Tax(AbsMediator _mediator) : base(_mediator)
        {

        }

        public void Drop()
        {
            base.mediator.Down(this);
        }

        public void Raise()
        {
            base.mediator.Up(this);
        }
    }
}
