namespace DesignPatternPK.Mediator_VS_Facade.Mediator
{
    //职位
    interface IPosition
    {
        //升职
        void Promote();
        //降职
        void Demote();
    }

    //工资
    interface ISalary
    {
        //加薪
        void IncreaseSalary();
        //降薪
        void DecreaseSalary();
    }

    //税收
    interface ITax
    {
        //税收上升
        void Raise();
        //税收下降
        void Drop();
    }
}
