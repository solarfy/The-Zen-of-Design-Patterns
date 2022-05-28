namespace DesignPatternPK.Mediator_VS_Facade.Mediator
{
    abstract class AbsMediator
    {
        protected IPosition position;
        protected ISalary salary;
        protected ITax tax;

        public AbsMediator()
        {
            position = new Position(this);
            salary = new Salary(this);
            tax = new Tax(this);
        }

        //升职
        public abstract void Up(IPosition position);
        //降职
        public abstract void Down(IPosition position);

        //加薪
        public abstract void Up(ISalary salary);
        //减薪
        public abstract void Down(ISalary salary);

        //增税
        public abstract void Up(ITax tax);
        //降税
        public abstract void Down(ITax tax);
    }
}
