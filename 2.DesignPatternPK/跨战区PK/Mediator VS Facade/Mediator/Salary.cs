namespace DesignPatternPK.Mediator_VS_Facade.Mediator
{
    class Salary : AbsBase, ISalary
    {
        public Salary(AbsMediator _mediator) : base(_mediator)
        {

        }

        public void DecreaseSalary()
        {
            base.mediator.Down(this);
        }

        public void IncreaseSalary()
        {
            base.mediator.Up(this);
        }
    }
}
