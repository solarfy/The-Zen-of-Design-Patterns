namespace ZenOfDesignPattern.Visitor_Pattern
{
    //抽象的汇总访问者
    interface ITotalVisitor : IVisitor
    {
        public void TotalNumber();
    }
}
