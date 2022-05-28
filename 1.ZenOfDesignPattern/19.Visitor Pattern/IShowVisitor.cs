namespace ZenOfDesignPattern.Visitor_Pattern
{
    //抽象的信息报表访问者
    interface IShowVisitor : IVisitor
    {
        void Show();
    }
}
