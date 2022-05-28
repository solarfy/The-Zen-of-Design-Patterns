namespace DesignPatternPK.Mediator_VS_Facade.Mediator
{
    class Position :AbsBase, IPosition
    {
        public Position(AbsMediator _mediator) : base(_mediator)
        {

        }

        public void Demote()
        {
            base.mediator.Down(this);
        }

        public void Promote()
        {
            base.mediator.Up(this);
        }
    }
}
