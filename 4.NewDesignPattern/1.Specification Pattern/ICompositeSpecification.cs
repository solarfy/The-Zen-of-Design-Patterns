namespace NewDesignPattern.Specification_Pattern
{
    //带与或非地规格书接口（支持复合查询）
    interface ICompositeSpecification
    {
        //候选者是否满足要求
        bool IsSatisfiedBy(User user);

        //与 （返回的是IUserSpecification，可实现链式写法）
        ICompositeSpecification AND(ICompositeSpecification spec);

        //或
        ICompositeSpecification OR(ICompositeSpecification spec);

        //非
        ICompositeSpecification NOT(ICompositeSpecification spec);
    }
}
