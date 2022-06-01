namespace NewDesignPattern.Specification_Pattern
{
    abstract class CompositeSpecification : ICompositeSpecification
    {
        //是否满足条件由实现类处理
        public abstract bool IsSatisfiedBy(User user);      

        //与
        public ICompositeSpecification AND(ICompositeSpecification spec)
        {
            return new AndSpecification(this, spec);
        }

        //非
        public ICompositeSpecification OR(ICompositeSpecification spec)
        {
            return new OrSpecification(this, spec);
        }

        //或
        public ICompositeSpecification NOT(ICompositeSpecification spec)
        {
            return new NotSpecification(spec);
        }
    }

    //与规格书
    class AndSpecification : CompositeSpecification
    {
        private ICompositeSpecification left;
        private ICompositeSpecification right;

        public AndSpecification(ICompositeSpecification _left, ICompositeSpecification _right)
        {
            left = _left;
            right = _right;
        }

        public override bool IsSatisfiedBy(User user)
        {
            return left.IsSatisfiedBy(user) && right.IsSatisfiedBy(user);
        }
    }

    //或规格书
    class OrSpecification : CompositeSpecification
    {
        private ICompositeSpecification left;
        private ICompositeSpecification right;

        public OrSpecification(ICompositeSpecification _left, ICompositeSpecification _right)
        {
            left = _left;
            right = _right;
        }

        public override bool IsSatisfiedBy(User user)
        {
            return left.IsSatisfiedBy(user) || right.IsSatisfiedBy(user);
        }
    }

    //非规格书
    class NotSpecification : CompositeSpecification
    {
        private ICompositeSpecification spec;

        public NotSpecification(ICompositeSpecification _spec)
        {
            spec = _spec;
        }

        public override bool IsSatisfiedBy(User user)
        {
            return !spec.IsSatisfiedBy(user);
        }
    }
}
